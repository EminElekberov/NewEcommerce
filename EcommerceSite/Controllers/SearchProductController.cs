using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class SearchProductController : Controller
    {
        private readonly SyteDbContext dbContext;
        public SearchProductController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IActionResult> Index(string SearchText="")
        {
            List<Product> product;
            if (SearchText != "" && SearchText != null)
            {
                product = await dbContext.Products.Include(x=>x.category).Include(x=>x.Reviews).Include(x=>x.ProductsToColors).ThenInclude(x=>x.color).Include(x=>x.SizeToProducts).ThenInclude(x=>x.Size).Where(x => x.Name.ToLower() == SearchText.ToLower()).ToListAsync();
            }
            else
            {
                product = await dbContext.Products.ToListAsync();
            }
            return View(product);
        }
    }
}
