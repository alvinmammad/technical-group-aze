using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalGroup.Models;

namespace TechnicalGroup.ViewModels
{
    public class VMBlog
    {
        public IEnumerable<Post> Posts { get; set; }
       
        public IEnumerable<PostWriter> Writers { get; set; }
        public int TotalPage { get; set; }
        public int Page { get; set; }
    }
}
