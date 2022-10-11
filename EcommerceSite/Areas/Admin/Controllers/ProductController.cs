using EcommerceSite.Extension;
using EcommerceSite.Models;
using EcommerceSite.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly SyteDbContext _dbcontext;
        private readonly IWebHostEnvironment env;
        private readonly IBookRepository _bookRepository = null;
        public ProductController(SyteDbContext portoDbContext, IWebHostEnvironment _env, IBookRepository bookRepository)
        {
            _dbcontext = portoDbContext;
            env = _env;
            _bookRepository = bookRepository;

        }
        public IActionResult Index()
        {
            ViewBag.PacketToColor = _dbcontext.ProductsToColors.Include(x => x.color).Include(y => y.Product).ToList();
            ViewBag.PacketToComponents = _dbcontext.SizeToProducts.Include(x => x.Size).Include(y => y.Product).ToList();
            var group = _dbcontext.Products.Include(x=>x.category).Include(x=>x.SizeToProducts).ThenInclude(x=>x.Size).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.Categories.ToList();
            ViewBag.Color = _dbcontext.Colors.ToList();
            ViewBag.Size = _dbcontext.sizes.ToList();
            ViewBag.Packets = _dbcontext.Products.ToList();
            return View();
        }
        #region
        //[HttpPost]
        //public async Task<IActionResult> Create(Category cases)
        //{
        //    #region
        //    if (!ModelState.IsValid && cases.Photo == null)
        //    {
        //        return Redirect("/NOtfound/ErrorPage");
        //    }
        //    if (cases.GalleryFiles != null)
        //    {
        //        string folders = "images/gallery/";

        //        cases.Gallery = new List<GalleryModel>();

        //        foreach (var file in cases.GalleryFiles)
        //        {
        //            var gallery = new GalleryModel()
        //            {
        //                Name = file.FileName,
        //                URL = await UploadImage(folders, file)
        //            };
        //            cases.Gallery.Add(gallery);
        //        }
        //    }
        //    if (!cases.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("photo", "Img formati dogru deyil");
        //        return View(cases);
        //    }
        //    string folder = @"images\categories";
        //    var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
        //    cases.Image = newImg;
        //    _dbcontext.Categories.Add(cases);
        //    _dbcontext.SaveChanges();
        //    return Redirect("/Admin/portfol/Index");
        //    #endregion
        //}
        #endregion

        [HttpPost]
        public async Task<IActionResult> Create(Product bookModel)
        {
            if (ModelState.IsValid)
            {
                if (bookModel.Photo != null)
                {
                    string folder = "images/categories/";
                    bookModel.Image = await UploadImage(folder, bookModel.Photo);
                }
                if (bookModel.GalleryFiles != null)
                {
                    string folder = "images/gallery/";

                    bookModel.ProductPictureGalleries = new List<ProductPictureGallery>();

                    foreach (var file in bookModel.GalleryFiles)
                    {
                        var gallery = new ProductPictureGallery()
                        {
                            Name = await UploadImage(folder, file)
                        };
                        bookModel.ProductPictureGalleries.Add(gallery);
                    }
                }

                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    ProductsToColors booksToColor = new ProductsToColors();
                    foreach (var item in bookModel.ColorId)
                    {
                        ProductsToColors packet = new ProductsToColors
                        {
                            ProductId = id,
                            colorId = item
                        };
                        _dbcontext.ProductsToColors.Add(packet);
                    }
                    SizeToProduct sizeToBooks = new SizeToProduct();
                    foreach (var item in bookModel.SizeId)
                    {
                        SizeToProduct size = new SizeToProduct
                        {
                            ProductId = id,
                            SizeId = item
                        };
                        _dbcontext.SizeToProducts.Add(size);
                    }
                    _dbcontext.SaveChanges();


                    return RedirectToAction(nameof(Create), new { isSuccess = true, bookId = id });
                }
            }
            return View();
        }
        private async Task<string> UploadImage(string folderPath, IFormFile file)
        {
            string result = Guid.NewGuid().ToString() + "_" + file.FileName;
            folderPath += result;
            string serverFolder = Path.Combine(env.WebRootPath, folderPath);
            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
            return result;
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            var cases = await _dbcontext.Categories.FindAsync(id);
            if (cases == null)
            {
                return NotFound();

            }
            _dbcontext.Categories.Remove(cases);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/category/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cases = _dbcontext.Categories.Find(id);
            if (cases == null)
            {
                return NotFound();

            }
            return View(cases);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product cases)
        {
            if (!ModelState.IsValid)
            {
                return View(cases);
            }
            var sliderdb = _dbcontext.Products.Find(cases.Id);
            if (cases.Photo != null)
            {
                try
                {
                    string folder = @"images\portfolio";
                    var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Name = cases.Name;
            sliderdb.PastPrice = cases.PastPrice;
            sliderdb.PresentPrice = cases.PresentPrice;
            sliderdb.Description = cases.Description;
            sliderdb.Percent = cases.Percent;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Product/Index");
        }
    }
}
