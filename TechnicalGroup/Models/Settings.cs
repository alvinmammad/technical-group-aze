using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace TechnicalGroup.Models
{
    public class Settings
    {
        public int ID { get; set; }

        public string SiteLogo { get; set; }
        [NotMapped]
        public IFormFile SiteLogoImage { get; set; }
        [EmailAddress]
        public string ContactEmail { get; set; }
        [Phone]
        public string ContactPhone { get; set; }
        [StringLength(200)]
        public string ContactAddress { get; set; }

        //public string GITphoto { get; set; }
        //[NotMapped]
        //public IFormFile GITimage { get; set; }

        //public string AboutPhoto { get; set; }
        [Required]
        [Column(TypeName ="ntext")]
        public string AboutDesc { get; set; }
        public string AboutDesc_Ru { get; set; }
        public string AboutDesc_Az { get; set; }
        [Required]
        [StringLength(65)]
        public string MainBannerTitle { get; set; }
        public string MainBannerTitle_Ru { get; set; }
        public string MainBannerTitle_Az { get; set; }
        //[Required]
        //public string MainBannerDesc { get; set; }
        //public string MainBannerDesc_Ru { get; set; }
        //public string MainBannerDesc_Az { get; set; }

    }
}
