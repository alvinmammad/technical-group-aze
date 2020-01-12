using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;

namespace TechnicalGroup.ViewModels
{
    public class VMAbout
    {
        public IEnumerable<AboutItems> AboutItems { get; set; }
        public IEnumerable<Facts> Facts { get; set; }
        public Settings Setting { get; set; }
    }
}
