using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace TechnicalGroup.Models
{
    public class ServiceItems
    {
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Title_Ru { get; set; }
        public string Title_Az { get; set; }

        [Required]
        public string Content { get; set; }

        public string Content_Ru { get; set; }
        public string Content_Az { get; set; }


    }
}
