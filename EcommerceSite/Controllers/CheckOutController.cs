using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly UserManager<User> userManager;
        public CheckOutController(SyteDbContext _dbContext,UserManager<User> _usermanager)
        {
            dbContext = _dbContext;
            userManager = _usermanager;
        }
        public IActionResult Index()
        {
            if (User.Identity.Name!=null)
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                if (cart != null)
                {
                    ViewBag.total = cart.Sum(item => item.Product.PresentPrice * item.Quantity);
                }
            }
            else
            {
                return Redirect("/Account/Login");
            }
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Sales checkout)
        {
            var user =await userManager.FindByEmailAsync(User.Identity.Name);
            if (user==null)
            {
                return NotFound();
            }
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            foreach (var item in cart)
            {
                Sales sales = new Sales
                {
                    UserId = user.Id,
                    ProductId = item.Product.Id,
                    Count = item.Quantity,
                    Price = item.Product.PresentPrice * item.Quantity,
                    CompanyName = checkout.CompanyName,
                    Country = checkout.Country,
                    EmailAddress = checkout.EmailAddress,
                    FirstName = checkout.FirstName,
                    LastName = checkout.LastName,
                    OrderInformation = checkout.OrderInformation,
                    PhoneNumber = checkout.PhoneNumber,
                    SteetAddress = checkout.SteetAddress,
                    Town = checkout.Town
                };
                await dbContext.Sales.AddAsync(sales);
            }
            await dbContext.SaveChangesAsync();
            return RedirectToAction("/Home/Index");
        }
    }
}
