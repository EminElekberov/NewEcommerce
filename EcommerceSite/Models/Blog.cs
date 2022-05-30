using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image{ get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Phorizm { get; set; }
        public IList<BlogReview> BlogReviews { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }

    }
}
