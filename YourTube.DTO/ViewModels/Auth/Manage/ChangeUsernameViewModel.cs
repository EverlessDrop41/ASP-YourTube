using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTube.DTO.ViewModels.Auth.Manage
{
    public class ChangeUsernameViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "New Username")]
        [StringLength(100, MinimumLength = 4)]
        public string NewUsername { get; set; }
    }
}
