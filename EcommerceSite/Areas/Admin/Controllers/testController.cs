using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
