﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime date { get; set; }
        public Product Product { get; set; }
        public int productId { get; set; }
    }
}
