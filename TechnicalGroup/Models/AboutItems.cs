using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class AboutItems
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Title_Ru { get; set; }
        [Required]
        public string Title_Az { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Content_Az { get; set; }
        [Required]
        public string Content_Ru { get; set; }


    }
}
