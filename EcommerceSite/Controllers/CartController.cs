using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var cart=SessionHelper.GetObjectFromJson<List<Item>>
            return View();
        }
    }
}
