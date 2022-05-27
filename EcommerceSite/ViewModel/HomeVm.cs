using EcommerceSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.ViewModel
{
    public class HomeVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Deals> Deals { get; set; }
        public List<Fabrica> Fabricas { get; set; }
        public Category Category { get; set; }
    }
}
