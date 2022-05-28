﻿using EcommerceSite.Models;
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

        public async Task<IActionResult> Index(int? id)
        {
            HomeVm homeVm = new HomeVm
            {
                Products =await dbContext.Products.Include(x => x.category).Include(x=>x.ProductPictureGalleries).Where(x => x.CategoryId == id).ToListAsync(),
                Categories=await dbContext.Categories.Include(x=>x.Products).ToListAsync(),
                SizeToProducts=await dbContext.SizeToProducts.ToListAsync(),
                Sizes=await dbContext.sizes.ToListAsync(),
                Colors=await dbContext.Colors.ToListAsync()
            };
            return View(homeVm);
        }
    }
}