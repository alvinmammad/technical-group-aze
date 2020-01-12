using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class Facts
    {
        public int ID { get; set; }

        public int Key { get; set; }
        [Required]
        public string Value { get; set; }

        public string Value_Ru { get; set; }
        public string Value_Az { get; set; }


    }
}
