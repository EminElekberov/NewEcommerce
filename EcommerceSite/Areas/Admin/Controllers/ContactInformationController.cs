using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactInformationController : Controller
    {
        private readonly SyteDbContext dbContext;
        public ContactInformationController(SyteDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.ContactInformation.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ContactInformation about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.ContactInformation.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/ContactInformation/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ContactInformation about = dbContext.ContactInformation.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ContactInformation about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.ContactInformation.Find(about.Id);
            chosedb.Title = about.Title;
            chosedb.Iconlink = about.Iconlink;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/ContactInformation/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            ContactInformation choose = await dbContext.ContactInformation.FindAsync(id);
            if (choose == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.ContactInformation.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/ContactInformation/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.ContactInformation.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
