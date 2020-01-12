using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TechnicalGroup.Models
{
    public class Projects
    {
        public Projects()
        {
            ProjectPhotos = new HashSet<ProjectPhotos>();
        }
        public int ID { get; set; }

        //[StringLength(1000)]
        //public string Slug { get; set; }
        [Required]
        public string LittleContent { get; set; }

        public string LittleContent_Ru { get; set; }

        public string LittleContent_Az { get; set; }


        [Required]
        [Column(TypeName ="ntext")]
        public string Description { get; set; }
        public string Description_Ru { get; set; }
        public string Description_Az { get; set; }

        public virtual ICollection<ProjectPhotos> ProjectPhotos { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public List<string> PhotoNames { get; set; }
    }
}
