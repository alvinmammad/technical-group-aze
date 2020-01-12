using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Models
{
    public class ProjectPhotos
    {
        public int ID { get; set; }
        public string Photo { get; set; }
       
        public int ProjectID { get; set; }

        public virtual Projects Project { get; set; }
    }
}
