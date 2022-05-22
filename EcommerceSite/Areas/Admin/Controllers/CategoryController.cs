using EcommerceSite.Extension;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public CategoryController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            dbContext = portoDbContext;
            env = _env;

        }
        public IActionResult Index()
        {
            return View(dbContext.Categories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Category clients = new Category();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category clients)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!clients.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "eroorrr");
                return View(clients);
            }
            string folder = @"images\products";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.Categories.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category client = dbContext.Categories.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.Categories.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\products";
                    var newImg = await slider.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Name = slider.Name;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Category/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category Clients = await dbContext.Categories.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.Categories.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Category/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Category Clients = dbContext.Categories.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
