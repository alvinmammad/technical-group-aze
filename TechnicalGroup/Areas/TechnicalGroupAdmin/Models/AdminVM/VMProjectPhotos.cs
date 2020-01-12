using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Models.AdminVM
{
    public class VMProjectPhotos
    {
        public List<ProjectPhotos> Photos { get; set; }
        public Projects Project { get; set; }
    }
}
