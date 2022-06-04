using EcommerceSite.Helper;
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
    public class CategoryController : Controller
    {
        private readonly SyteDbContext dbContext;
        public CategoryController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index(int? id,int page=1)
        {
            int take = 1;
            HomeVm homeVm = new HomeVm
            {
                Pagination=new PaginationModel(await dbContext.Products.CountAsync(),take,page),
                Products =await dbContext.Products.Include(x => x.category).Include(x=>x.ProductPictureGalleries).Where(x => x.CategoryId == id).Skip(take * (page - 1)).Take(take).ToListAsync(),
                Categories=await dbContext.Categories.Include(x=>x.Products).ToListAsync(),
                SizeToProducts=await dbContext.SizeToProducts.ToListAsync(),
                listct=await dbContext.Categories.Where(x=>x.Id==id).Include(x=>x.Products).ToListAsync(),
                Sizes=await dbContext.sizes.ToListAsync(),
                Colors=await dbContext.Colors.ToListAsync()
            };
            return View(homeVm);
        }
    }
}
