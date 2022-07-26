using EcommerceSite.Models;
using EcommerceSite.Service;
using EcommerceSite.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class AccountController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        public AccountController(SyteDbContext _dbContext,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole> roleManager,
            IEmailService emailService)
        {
            dbContext = _dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            var username = await _userManager.FindByEmailAsync(loginVm.Email);
            var result = await _signInManager.PasswordSignInAsync(username, loginVm.Password, false, false);
            if (result.Succeeded)
            {
                    return Redirect($"/Home/Index/{username.Email}");
            }
            return View(loginVm);
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterVM userRegisterVM)
        {
            if (_userManager.FindByEmailAsync(userRegisterVM.Email).Result == null)
            {
                User user = new User
                {
                    UserName = userRegisterVM.Email,
                    Email = userRegisterVM.Email,
                    Password = userRegisterVM.Password,
                    FirstName = userRegisterVM.FirstName,
                    LastName = userRegisterVM.LastName
                };
                var result = await _userManager.CreateAsync(user, userRegisterVM.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                    await _signInManager.SignInAsync(user, false);
                    return Redirect("/UserAccount/Login");
                }
            }
            return View(userRegisterVM);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Edit()
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateVm userUpdateVm = new UserUpdateVm
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
            return View(userUpdateVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Edit(UserUpdateVm userUpdateVm)
        {
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Email != userUpdateVm.Email && _userManager.Users.Any(x => x.NormalizedEmail == userUpdateVm.Email.ToUpper()))
            {
                ModelState.AddModelError("", "Username is already exists");
                return View();
            }
            if (!string.IsNullOrWhiteSpace(userUpdateVm.NewPassword))
            {
                if (userUpdateVm.NewPassword != userUpdateVm.NewConfirmPassword)
                {
                    ModelState.AddModelError("", "Pasword with not matched confirm pass");
                    return View();
                }
                var result = await _userManager.ChangePasswordAsync(user, userUpdateVm.CurrentPassword, userUpdateVm.NewPassword);
                if (result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }
                }

            }
            user.FirstName = userUpdateVm.FirstName;
            user.LastName = userUpdateVm.LastName;
            user.Email = userUpdateVm.Email;
            await _userManager.UpdateAsync(user);
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetVM)
        {
            User user = await _userManager.FindByEmailAsync(forgetVM.Email);
            if (user==null)
            {
                ModelState.AddModelError("", "email was not found");
                return View();
            }

            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string callback = Url.Action("resetpassword", "userAccount", new { token, email = user.Email }, Request.Scheme);
            string body = string.Empty;
            using (StreamReader reader=new StreamReader("wwwroot/templates/forgetpasswod.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{url}", callback);
            _emailService.Send(user.Email, "Reset Password", body);
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> ResetPassword(string token, string email)
        {
            ResetPasswordVM resetPasswordVM = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetPasswordVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        {
            User user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(resetPasswordVM);
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
