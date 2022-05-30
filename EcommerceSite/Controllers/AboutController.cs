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
    public class AboutController : Controller
    {
        private readonly SyteDbContext dbContext;
        public AboutController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                Abouts=await dbContext.Abouts.ToListAsync(),
                whoWeAres=await dbContext.whoWeAres.ToListAsync(),
                Fabricas=await dbContext.Fabricas.ToListAsync(),
                MyTeams=await dbContext.MyTeams.ToListAsync(),
                Clients=await dbContext.Clients.ToListAsync()
            };
            return View(homeVm);
        }
    }
}
