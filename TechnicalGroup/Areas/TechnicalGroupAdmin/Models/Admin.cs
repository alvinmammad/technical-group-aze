using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.Areas.TechnicalGroupAdmin.Models
{
    public class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage ="İstifadəçi adı yanlışdır")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrə yanlışdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
