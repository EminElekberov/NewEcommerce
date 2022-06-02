using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewComponents
{
    public class VcWish: ViewComponent
    {
        private readonly SyteDbContext dbContext;
        public VcWish(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var wish = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish");
            ViewBag.wish = wish;
            return View();
        }
    }
}
