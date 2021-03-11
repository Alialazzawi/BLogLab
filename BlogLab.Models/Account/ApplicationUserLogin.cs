using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage ="Username is required")]
        [MinLength(5, ErrorMessage = "Username must be between 5-20 char") ]
        [MaxLength(20, ErrorMessage = "Username must be between 5-20 char")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Password must be between 10-50 char")]
        [MaxLength(50, ErrorMessage = "Password must be between 10-50 char")]
        public string Password{ get; set; }
    }
}
