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
        public List<Product> produ { get; set; }
        public List<Review> listRewiew { get; set; }
        public List<Review> Reviews { get; set; }
        public List<ProductsToColors> ProductsToColors { get; set; }
        public List<Deals> Deals { get; set; }
        public List<Size> Sizes{ get; set; }
        public Review Review { get; set; }
        public List<SizeToProduct> SizeToProducts { get; set; }
        public List<ProductPictureGallery> ProductPictureGalleries { get; set; }
        public List<Property> Properties { get; set; }
        public List<Fabrica> Fabricas { get; set; }
        public List<Color> Colors{ get; set; }
        public Category Category { get; set; }
    }
}
