using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comments>();
           
        }

        [Required]
        public int ID { get; set; }

        //[StringLength(1000)]
        //public string Slug { get; set; }

        public string Image { get; set; }
        [NotMapped]
        
        public IFormFile Photo { get; set; }

        public DateTime CreatedDate { get; set; }
        [Required]
        public string Title { get; set; }

        public string Title_Ru { get; set; }
        public string Title_Az { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        public string Text_Ru { get; set; }
        public string Text_Az { get; set; }


        public string InstagramURL { get; set; }

        public int PostWriterID { get; set; }

        public virtual PostWriter PostWriter { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }

       
    }
}
