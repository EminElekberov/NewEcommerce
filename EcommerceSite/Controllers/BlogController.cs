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
    public class BlogController : Controller
    {
        private readonly SyteDbContext dbContext;
        public BlogController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Blogs=await dbContext.Blogs.Include(x=>x.category).ToListAsync(),
                Categories=await dbContext.Categories.Include(x=>x.Products).ToListAsync()
            };
            return View(homeVm);
        }
    }
}
