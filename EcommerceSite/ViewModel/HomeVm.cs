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
        public List<BlogReview> blogReviews { get; set; }
        public List<OurStores> ourStores { get; set; }
        public List<About> Abouts { get; set; }
        public List<WhoWeAre> whoWeAres { get; set; }
        public List<ContactInformation> ContactInformation{ get; set; }
        public List<MyTeam> MyTeams { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Blog> Allblog { get; set; }
        public BlogReview BlogReview { get; set; }
        public List<FaqTitle> faqTitles { get; set; }
        public List<FaqComponent> faqComponents { get; set; }
        public List<Client> Clients{ get; set; }
        public List<Review> listRewiew { get; set; }
        public List<Review> Reviews { get; set; }
        public List<ProductsToColors> ProductsToColors { get; set; }
        public List<Deals> Deals { get; set; }
        public ContactForm ContactForm { get; set; }
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
