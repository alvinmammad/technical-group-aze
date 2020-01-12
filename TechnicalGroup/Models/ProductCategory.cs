using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Products>();
        }

        public int ID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string CategoryName_Ru { get; set; }
        public string CategoryName_Az { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
