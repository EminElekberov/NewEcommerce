﻿using EcommerceSite.Helper;
using EcommerceSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Controllers
{
    public class CompareController : Controller
    {
        private readonly SyteDbContext dbContext;
        public CompareController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            var comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");
            ViewBag.comp = comp;
            return View();
        }
        public async Task<IActionResult> Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp") == null)
            {
                List<Item> comp = new List<Item>();
                foreach (var item in comp)
                {
                  var s=item.Product.category.Name;
                }
                comp.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "comp", comp);
            }
            else
            {
                List<Item> comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");

                comp.Add(new Item { Product = dbContext.Products.Where(x => x.Id == id).FirstOrDefault(), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "comp", comp);
            }
            return RedirectToAction("Index");
        }
        private int IsExist(int id)
        {
            List<Item> comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");
            for (int i = 0; i < comp.Count; i++)
            {
                if (comp[i].Product.Id.Equals(id))
                {
                    return i;
                }

            }
            return -1;
        }
        public async Task<IActionResult> Remove(int id)
        {
            List<Item> comp = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "comp");
            int index = IsExist(id);
            comp.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "comp", comp);
            return RedirectToAction("Index");
        }
    }
}