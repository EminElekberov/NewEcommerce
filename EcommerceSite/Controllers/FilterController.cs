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

        public async Task<IActionResult> Index(int rangePrimary, int size, int coloin)
        {
            List<Product> sizeToProducts = new List<Product>();
            List<SizeToProduct> sizes = new List<SizeToProduct>();
            List<ProductsToColors> productsToColors = new List<ProductsToColors>();
            if (rangePrimary == null && size == null && coloin == null)
            {
                //var ele = await  dbContext.Blogs.FromSqlRaw("").ToListAsync()

                return NotFound();
            }
            else
            {
                //sizes = await dbContext.SizeToProducts.Include(x => x.Size).Include(x => x.Product).Where(x => x.Size.id == size).ToListAsync();
                //productsToColors = await dbContext.ProductsToColors.Include(x => x.color).Include(x => x.Product).Where(x => x.color.Id == coloin).ToListAsync();
                //sizes = await dbContext.SizeToProducts.Where(x => x.Size.id == size).Where(x => x.Product.PresentPrice <= rangePrimary).ToListAsync();
                //productsToColors = await dbContext.ProductsToColors.Where(x => x.color.Id == coloin).ToListAsync();
                //foreach (var item in productsToColors)
                //{
                //    item.Product
                //}

            }
            return View(sizeToProducts);
        }
    }
}
