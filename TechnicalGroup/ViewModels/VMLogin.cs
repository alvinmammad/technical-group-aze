using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalGroup.ViewModels
{
    public class VMLogin
    {
        [Required(ErrorMessage = "İstifadəçi adı boş ola bilməz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrə boş ola bilməz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
