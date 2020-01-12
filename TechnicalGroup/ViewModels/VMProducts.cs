using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;
namespace TechnicalGroup.ViewModels
{
    public class VMProducts
    {
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<ProductPhotos> Photos { get; set; }
        public IEnumerable<ProductCategory> Categories { get; set; }
        public int TotalPage { get; set; }
        public int Page { get; set; }
    }
}
