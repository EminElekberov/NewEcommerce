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

    public class FaqController : Controller
    {
        private readonly SyteDbContext dbContext;
        public FaqController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                faqComponents = await dbContext.FaqComponents.Include(x => x.FaqTitle).ToListAsync(),
                faqTitles=await dbContext.FaqTitles.Include(x=>x.faqComponents).ToListAsync()
            };
            return View(homeVm);
        }
    }
}
