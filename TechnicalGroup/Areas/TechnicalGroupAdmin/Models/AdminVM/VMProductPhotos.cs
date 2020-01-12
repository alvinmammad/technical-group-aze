using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM
{
    public class VMProductPhotos
    {
        public List<ProductPhotos> Photos { get; set; }
        public Products Product { get; set; }
    }
}
