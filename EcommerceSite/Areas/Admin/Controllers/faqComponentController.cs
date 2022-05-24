using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class faqComponentController : Controller
    {
        private readonly SyteDbContext _dbcontext;

        public faqComponentController(SyteDbContext portoDbContext)
        {
            _dbcontext = portoDbContext;
        }
        public IActionResult Index()
        {
            var group = _dbcontext.FaqComponents.Include(x => x.FaqTitle).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.FaqTitles.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(FaqComponent cases)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            _dbcontext.FaqComponents.Add(cases);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/FaqComponent/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var search = await _dbcontext.FaqComponents.FindAsync(id);
            _dbcontext.FaqComponents.Remove(search);
            await _dbcontext.SaveChangesAsync();
            return View("/Admin/FaqComponent/index");
        }
    }
}
