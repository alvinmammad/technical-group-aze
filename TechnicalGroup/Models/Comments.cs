using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class Comments
    {
        public int ID {get; set; }

        [Column(TypeName = "ntext")]

        public string Text { get; set; }

        public string OwnerFullname { get; set; }

        public string OwnerEmail { get; set; }

        public DateTime Date { get; set; }

        public int PostID { get; set; }

        public virtual Post Post { get; set; }
    }
}
