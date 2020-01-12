using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;
namespace TechnicalGroup.ViewModels
{
    public class VMSingleBlog
    {
        public Post Post { get; set; }
        public IEnumerable<Comments> Comments { get; set; }

    }
}
