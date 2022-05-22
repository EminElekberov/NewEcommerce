using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PropertyController : Controller
    {
        private readonly SyteDbContext dbContext;
        public PropertyController(SyteDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Properties.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Property about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.Properties.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Property/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Property about = dbContext.Properties.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Property about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.Properties.Find(about.Id);
            chosedb.Iconlink = about.Iconlink;
            chosedb.Name = about.Name;
            chosedb.Descripiton = about.Descripiton;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Property/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            Property choose = await dbContext.Properties.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.Properties.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Property/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.Properties.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
