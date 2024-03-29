﻿using EcommerceSite.Extension;
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
    public class DealsController : Controller
    {
        private readonly SyteDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public DealsController(SyteDbContext portoDbContext, IWebHostEnvironment _env)
        {
            dbContext = portoDbContext;
            env = _env;

        }
        public IActionResult Index()
        {
            return View(dbContext.Deals.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Deals clients = new Deals();
            return View(clients);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Deals clients)
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
            string folder = @"images\Deals";
            //string folder = @"images\uploads";
            clients.Image = await clients.Photo.SaveAsync(env.WebRootPath, folder);
            await dbContext.Deals.AddAsync(clients);
            await dbContext.SaveChangesAsync();
            return Redirect("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Deals client = dbContext.Deals.Find(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Deals slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = dbContext.Deals.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\Deals";
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
            sliderdb.Title = slider.Title;
            sliderdb.PastPrice = slider.PastPrice;
            sliderdb.PresentPrice= slider.PresentPrice;
            sliderdb.Date= slider.Date;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Deals/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Deals Clients = await dbContext.Deals.FindAsync(id);
            if (Clients == null)
            {
                return NotFound();
            }
            dbContext.Deals.Remove(Clients);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Category/Index");

        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Deals Clients = dbContext.Deals.Find(id);
            if (Clients == null)
            {
                return NotFound();
            }
            return View(Clients);
        }
    }
}
