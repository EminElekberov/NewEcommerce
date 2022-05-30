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
    public class ContactController : Controller
    {
        private readonly SyteDbContext dbContext;
        public ContactController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index()
        {
            HomeVm homeVm = new HomeVm
            {
                ContactInformation = await dbContext.ContactInformation.ToListAsync(),
                ourStores = await dbContext.OurStores.ToListAsync()
            };
            return View(homeVm);
        }
        [HttpPost]
        public async Task<IActionResult> Index(ContactForm contact)
        {
            if (contact == null)
            {
                return NotFound();
            }
            dbContext.ContactForms.Add(contact);
            dbContext.SaveChanges();
            return Redirect("/Contact/index");
        }
    }
}
