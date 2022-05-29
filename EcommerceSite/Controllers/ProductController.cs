using EcommerceSite.Models;
using EcommerceSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class ProductController : Controller
    {
        private readonly SyteDbContext dbContext;
        public ProductController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IActionResult> Details(int? id)
        {
            HomeVm homeVm = new HomeVm
            {
                Products = await dbContext.Products.Where(x=>x.Id==id).Include(x => x.category).Include(x => x.ProductsToColors).ThenInclude(x => x.color).Include(x => x.SizeToProducts).ThenInclude(x => x.Size).Include(x=>x.ProductPictureGalleries).ToListAsync(),
                listRewiew = dbContext.Reviews.Where(x => x.productId == id).ToList(),

            };
            return View(homeVm);
        }
        [HttpPost]
        public async Task<IActionResult> Details(Review review)
        {
            // var user = await dbContext.Books.FindAsync(review.Id);
            if (review == null)
            {
                return NotFound();
            }
            dbContext.Reviews.Add(new Review { productId = review.Id, Message = review.Message, Email = review.Email, Name = review.Name, date = DateTime.Now.Date });
            await dbContext.SaveChangesAsync();
            return Redirect($"/categories/details/{review.Id}");
        }
    }
}
