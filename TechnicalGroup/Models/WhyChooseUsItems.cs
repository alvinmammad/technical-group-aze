using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class WhyChooseUsItems
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Title_Ru { get; set; }
        public string Title_Az { get; set; }
        public string Info { get; set; }
        public string Info_Ru { get; set; }
        public string Info_Az { get; set; }

    }
}
