using EcommerceSite.Models;
using EcommerceSite.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewComponents
{
    public class VcBlog : ViewComponent
    {
        private readonly SyteDbContext dbContext;
        public VcBlog(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IViewComponentResult Invoke()
        {
            HomeVm home = new HomeVm
            {
                Blogs = dbContext.Blogs.Include(x => x.category).ToList(),
                Categories = dbContext.Categories.Include(x => x.Products).ToList()
            };

            return View(home);
        }

    }
}
