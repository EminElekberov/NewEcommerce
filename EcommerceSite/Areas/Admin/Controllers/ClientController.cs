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
    public class ClientController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public ClientController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            dbContext = portoDbContext;
            env = _env;

        }
        public IActionResult Index()
        {
            return View(dbContext.Clients.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Client clients = new Client();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Client clients)
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
            string folder = @"images\client";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.Clients.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Client client = dbContext.Clients.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Client slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.Clients.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\client";
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
            sliderdb.Name = slider.Name;
            sliderdb.Description = slider.Description;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/client/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Client Clients = await dbContext.Clients.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.Clients.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/client/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Client Clients = dbContext.Clients.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
