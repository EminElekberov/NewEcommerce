using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PresentPrice { get; set; }
        public int PastPrice { get; set; }
        public string Description { get; set; }
        public string Information { get; set; }
        public string ShippinandReturns { get; set; }
        public int Percent { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public IList<ProductPictureGallery> ProductPictureGalleries { get; set; }
        public IList<Review> Reviews { get; set; }
        [NotMapped]
        public List<int> ColorId { get; set; }
        [NotMapped]
        public IFormFileCollection GalleryFiles { get; set; }
        public IList<ProductsToColors> ProductsToColors { get; set; }
        [NotMapped]
        public List<int> SizeId { get; set; }
        public IList<SizeToProduct> SizeToProducts { get; set; }
        public IList<Sales> sales { get; set; }

    }
}
