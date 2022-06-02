using EcommerceSite.Models;
using EcommerceSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly SyteDbContext dbContext;
        public HomeController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Categories = await dbContext.Categories.Include(z=>z.Products).ToListAsync(),
                Products = await dbContext.Products.Include(x => x.category).Include(x=>x.Reviews).ToListAsync(),
                Fabricas = await dbContext.Fabricas.ToListAsync(),
                Deals=await dbContext.Deals.ToListAsync(),
                Properties=await dbContext.Properties.ToListAsync(),
                ProductsToColors=await dbContext.ProductsToColors.Include(x=>x.Product).Include(x=>x.color).ToListAsync()
            };
            return View(homeVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
