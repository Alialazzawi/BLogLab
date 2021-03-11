using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate:ApplicationUserLogin
    {
      
        [MinLength(10, ErrorMessage = "Fullname must be between 10-30 char")]
        [MaxLength(30, ErrorMessage = "Fullname must be between 10-30 char")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Email max length is 30 char")]
        [EmailAddress(ErrorMessage ="Invalid Email addres")]
        public string Email { get; set; }

    }
}
