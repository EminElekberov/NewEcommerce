using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewComponents
{

    public class VcCart: ViewComponent
    {
        private readonly SyteDbContext dbContext;
        public VcCart(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public  IViewComponentResult Invoke()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => item.Product.PresentPrice * item.Quantity);
            }
            return View();
        }

    }
}
