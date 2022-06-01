using EcommerceSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AboutController : Controller
    {
        private readonly SyteDbContext dbContext;
        public AboutController(SyteDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Abouts.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(About about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.Abouts.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/About/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            About about = dbContext.Abouts.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(About about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.Abouts.Find(about.Id);
            chosedb.Title = about.Title;
            chosedb.Description = about.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/About/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            About choose = await dbContext.Abouts.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.Abouts.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/About/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.Abouts.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
