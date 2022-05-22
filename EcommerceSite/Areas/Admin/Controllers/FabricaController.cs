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
    public class FabricaController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public FabricaController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            dbContext = portoDbContext;
            env = _env;

        }
        public IActionResult Index()
        {
            return View(dbContext.Fabricas.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Fabrica clients = new Fabrica();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Fabrica clients)
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
            string folder = @"images\Fabrica";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.Fabricas.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Fabrica client = dbContext.Fabricas.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Fabrica slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.Fabricas.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\Fabrica";
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
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Fabrica/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Fabrica Clients = await dbContext.Fabricas.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.Fabricas.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Fabrica/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Fabrica Clients = dbContext.Fabricas.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
