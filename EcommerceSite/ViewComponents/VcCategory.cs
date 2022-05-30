using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewComponents
{
    public class VcCategory: ViewComponent
    {
        private readonly SyteDbContext dbContext;
        public VcCategory(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var model = dbContext.Categories.ToList();
            return View(model);
        }
    }
}
