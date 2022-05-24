using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class FaqComponent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ToggleHref { get; set; }
        public virtual FaqTitle FaqTitle { get; set; }
        public int FaqTitleId { get; set; }
    }
}
