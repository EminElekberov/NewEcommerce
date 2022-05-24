using EcommerceSite.Extension;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly SyteDbContext _dbcontext;
        private readonly IWebHostEnvironment env;
        public BlogController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            _dbcontext = portoDbContext;
            env = _env;
        }
        public IActionResult Index()
        {
            var group = _dbcontext.Blogs.Include(x => x.category).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blog cases)
        {
            if (!ModelState.IsValid && cases.Photo == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            if (!cases.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(cases);
            }
            string folder = @"images\blogs";
            var newImg = await cases.Photo.SaveAsync(env.WebRootPath, folder);
            cases.Image = newImg;
            //cases.Date =DateTime.Parse(date);
            //new Blog {Date = DateTime.Parse(DateTime.Now.ToString("dddd, dd MMMM yyyy")), Title = cases.Title, Description = cases.Description, Phorizm = cases.Phorizm, CategoryId = cases.CategoryId }
            _dbcontext.Blogs.Add(cases);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/Blog/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var search = await _dbcontext.Blogs.FindAsync(id);
            _dbcontext.Blogs.Remove(search);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Blog/Index");
        }
    }
}
