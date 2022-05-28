using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class FilterController : Controller
    {
        private readonly SyteDbContext dbContext;
        public FilterController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index(int rangePrimary,int size,int coloin)
        {
            List<Product> sizeToProducts = new List<Product>();
            if (rangePrimary == null && size==null && coloin==null)
            {
                return NotFound();
            }
            else
            {
                sizeToProducts = await dbContext.Products.Include(x => x.SizeToProducts).ThenInclude(z => z.Size).Include(z => z.ProductsToColors).ThenInclude(z => z.color).Where(x => x.PresentPrice <= rangePrimary && x.SizeId==size).ToListAsync();
            }
            return View(sizeToProducts);
        }
    }
}
