using EcommerceSite.Helper;
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
    public class BlogController : Controller
    {
        private readonly SyteDbContext dbContext;
        public BlogController(SyteDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            int take = 1;
            HomeVm homeVm = new HomeVm
            {
                Pagination = new PaginationModel(await dbContext.Blogs.CountAsync(), take, page),
                Blogs = await dbContext.Blogs.Include(x=>x.category).Skip(take*(page-1)).Take(take).ToListAsync(),
                Categories=await dbContext.Categories.Include(x=>x.Products).ToListAsync()
            };
            return View(homeVm);
        }
        public async Task<IActionResult> Details(int? id)
        {
            HomeVm home = new HomeVm
            {
                Blogs=await dbContext.Blogs.Include(x=>x.category).Where(x=>x.Id==id).ToListAsync(),
                Allblog=await dbContext.Blogs.Include(x=>x.category).ToListAsync(),
                blogReviews=await dbContext.BlogReviews.Where(x=>x.BlogId==id).ToListAsync()
            };
            return View(home);
        }
        [HttpPost]
        public async Task<IActionResult> Details(BlogReview blogReview)
        {
            if (blogReview==null)
            {
                return NotFound();
            }
            await dbContext.BlogReviews.AddAsync(new BlogReview { BlogId = blogReview.Id,Name=blogReview.Name,Message=blogReview.Message,Email=blogReview.Email }) ;
            await dbContext.SaveChangesAsync();
            return Redirect($"/blog/details/{blogReview.Id}");
        }
    }
}
