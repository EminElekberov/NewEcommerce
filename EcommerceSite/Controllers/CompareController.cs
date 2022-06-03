using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class CompareController : Controller
    {
        private readonly SyteDbContext dbContext;
        public CompareController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");
            ViewBag.comp = comp;
            return View();
        }
        public async Task<IActionResult> Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp") == null)
            {
                List<Item> comp = new List<Item>();
                comp.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "comp", comp);
            }
            else
            {
                List<Item> comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");

                comp.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "comp", comp);
            }
            return RedirectToAction("Index");
        }
    }
}
