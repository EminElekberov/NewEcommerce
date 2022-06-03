using EcommerceSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class UserController : Controller
    {
        private readonly SyteDbContext dbContext;
        public UserController(SyteDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.Users.ToList());
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var delete = dbContext.Users.Find(id);
            if (delete==null)
            {
                return NotFound();
            }
            dbContext.Remove(delete);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/User/Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var delete = dbContext.Users.Find(id);
            if (delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }
    }
}
