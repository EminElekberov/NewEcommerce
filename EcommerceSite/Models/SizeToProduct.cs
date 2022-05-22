using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class SizeToProduct
    {
        public int SizeId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Size Size { get; set; }
    }
}
