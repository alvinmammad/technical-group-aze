using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class PostWriter
    {
        public PostWriter()
        {
            Posts = new HashSet<Post>();
        }

        public int ID { get; set; }

        public string Fullname { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
