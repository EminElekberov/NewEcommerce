using EcommerceSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(SyteDbContext _dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            dbContext = _dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task SeedRole()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }

            if (!await _roleManager.RoleExistsAsync(roleName: "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "User"));
            }
        }
        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("emin@gmail.com").Result==null)
            {
                User identityUser = new User
                {
                    UserName="emin",
                    Email= "emin@gmail.com"
                };
                IdentityResult result = await _userManager.CreateAsync(identityUser, "emin2001.!W");
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(identityUser, "Admin").Wait();
                    await dbContext.SaveChangesAsync();
                    await _signInManager.SignInAsync(identityUser, true);
                }
            }
        }
    }
}
