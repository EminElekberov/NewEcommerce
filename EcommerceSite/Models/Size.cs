using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class Size
    {
        public int id { get; set; }
        public string Name { get; set; }
        public IList<SizeToProduct> SizeToProducts { get; set; }
    }
}
