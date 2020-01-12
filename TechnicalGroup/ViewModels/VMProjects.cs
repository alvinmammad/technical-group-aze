using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;
namespace TechnicalGroup.ViewModels
{
    public class VMProjects
    {
        public IEnumerable<ProjectPhotos> ProjectPhotos { get; set; }
        public IEnumerable<Projects> Projects { get; set; }
    }
}
