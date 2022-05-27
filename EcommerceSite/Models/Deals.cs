using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class Deals
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        [Required]
        public double PresentPrice { get; set; }
        public double PastPrice { get; set; }
        public string Date { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
