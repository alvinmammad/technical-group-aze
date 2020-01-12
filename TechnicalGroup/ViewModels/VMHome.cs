using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;
namespace TechnicalGroup.ViewModels
{
    public class VMHome
    {
        public IEnumerable<HomeAboutItems> AboutItems { get; set; }
        public IEnumerable<ServiceItems> ServiceItems { get; set; }
        public IEnumerable<Facts> Facts { get; set; }
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Projects> Projects { get; set; }
    }
}
