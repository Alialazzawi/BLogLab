using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [MinLength(10, ErrorMessage = "Title must be between 10-50 char")]
        [MaxLength(50, ErrorMessage = "Title must be between 10-50 char")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Content must be between 300-3000 char")]
        [MaxLength(3000, ErrorMessage = "Content must be between 300-3000 char")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }


    }
}
