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
    public class Products
    {
       
        public int ID { get; set; }

        //[StringLength(1000)]
        //public string Slug { get; set; }
        public int Price { get; set; }
        [Required]
        public string Info { get; set; }

        public string Info_Ru { get; set; }
        public string Info_Az { get; set; }
        [Required(ErrorMessage ="Məhsulun adı boş ola bilməz")]
        public string Name { get; set; }

        public int? Discount { get; set; }

        public bool IsActive { get; set; }

        [Column(TypeName ="ntext")]
        [Required]
        public string Description { get; set; }

        public string Description_Ru { get; set; }
        public string Description_Az { get; set; }


        public int ProductCategoryID { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }


        public virtual ICollection<ProductPhotos> ProductPhotos { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required(ErrorMessage ="Şəkil boş olmamalıdır")]
        [NotMapped]
        public List<string> PhotoNames { get; set; }
    }
}
