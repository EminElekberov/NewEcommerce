using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class WishController : Controller
    {
        private readonly SyteDbContext dbContext;
        public WishController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var wish = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish");
            ViewBag.wish = wish;
            //if (wish != null)
            //{
            //    ViewBag.total = wish.Sum(item => item.Product.PresentPrice * item.Quantity);
            //}
            return View();
        }
        private int IsExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }

            }
            return -1;
        }
        public async Task<IActionResult> Buy(int id, int? page)
        {

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish") == null)
            {
                List<Item> wish = new List<Item>();
                wish.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = page ?? 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "wish", wish);
            }
            else
            {
                List<Item> wish = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish");
                int index = IsExist(id);
                if (index != -1)
                {
                    wish[index].Quantity++;
                }
                else
                {
                    wish.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = page ?? 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "wish", wish);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "wish");
            int index = IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "wish", cart);
            return RedirectToAction("Index");
        }

    }
}
