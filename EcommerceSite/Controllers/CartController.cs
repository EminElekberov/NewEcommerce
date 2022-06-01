using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//0513693886
namespace EcommerceSite.Controllers
{
    public class CartController : Controller
    {
        private readonly SyteDbContext dbContext;
        public CartController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if (cart!=null)
            {
                ViewBag.total = cart.Sum(item => item.Product.PresentPrice * item.Quantity);
            }
            return View();
        }
        private int IsExist(int id)
        {
            List<Item> cart=SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
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

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = page ?? 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = IsExist(id);
                if (index!=-1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = page ?? 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index=IsExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

    }
}
