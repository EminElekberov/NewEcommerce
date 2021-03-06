using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Password { get; set; }
        public virtual IList<Sales> Sales { get; set; }
        public virtual ICollection<Checkout> Checkouts { get; set; }

    }
}
