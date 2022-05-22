using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProductsToColors> ProductsToColors { get; set; }
    }
}
