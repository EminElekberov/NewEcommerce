using EcommerceSite.Extension;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WhoWeAreController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public WhoWeAreController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            dbContext = portoDbContext;
            env = _env;

        }
        public IActionResult Index()
        {
            return View(dbContext.whoWeAres.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            WhoWeAre clients = new WhoWeAre();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(WhoWeAre clients)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!clients.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "eroorrr");
                return View(clients);
            }
            string folder = @"images\weare";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.whoWeAres.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            WhoWeAre client = dbContext.whoWeAres.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(WhoWeAre slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.whoWeAres.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\weare";
                    var newImg = await slider.Photo.SaveAsync(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Title = slider.Title;
            sliderdb.Description= slider.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/WhoWeAre/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            WhoWeAre Clients = await dbContext.whoWeAres.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.whoWeAres.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/WhoWeAre/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            WhoWeAre Clients = dbContext.whoWeAres.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
