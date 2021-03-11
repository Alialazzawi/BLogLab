using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {

        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }
        
        
        [Required(ErrorMessage = "Content is required")]
        [MinLength(10, ErrorMessage = "Content must be  10-300 char")]
        [MaxLength(300, ErrorMessage = "Content must be 10-300 char")]
        public int BlogId { get; set; }



        public string Content { get; set; }


    }
}
