

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class FaqTitle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FaqComponent> faqComponents { get; set; }
    }
}
