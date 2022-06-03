using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewComponents
{
    public class VcCompare: ViewComponent
    {
        private readonly SyteDbContext dbContext;
        public VcCompare(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");
            ViewBag.comp = comp;
            return View();
        }
    }
}
