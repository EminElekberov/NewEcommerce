using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactFormController : Controller
    {
        private readonly SyteDbContext dbContext;
        public ContactFormController(SyteDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.ContactForms.ToList());
        }
        [HttpGet]
        public IActionResult CreateOpinion(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ContactForm contact = dbContext.ContactForms.Find(id);
            if (contact == null)
            {
                return NotFound();

            }
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOpinion(ContactForm contact)
        {
            #region
            //if (!ModelState.IsValid)
            //{
            //    ModelState.AddModelError("Error", "Error");
            //    return View();
            //}
            //await _dbcontext.Contacts.AddAsync(contact);
            //await _dbcontext.SaveChangesAsync();
            //return Redirect("Index");
            #endregion
            if (ModelState.IsValid)
            {
                return View(contact);
            }
            var sliderdb = dbContext.ContactForms.Find(contact.Id);
            sliderdb.MyOpinion = contact.MyOpinion;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/ContactForm/Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            ContactForm contact = await dbContext.ContactForms.FindAsync(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            dbContext.ContactForms.Remove(contact);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/ContactForm/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            var contact = dbContext.ContactForms.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
    }
}
