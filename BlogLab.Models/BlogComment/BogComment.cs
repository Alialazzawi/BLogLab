﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BogComment: BlogCommentCreate
    {
        public string Username { get; set; }

        public int ApplicationUserId { get; set; }

        public DateTime PublishedDate { get; set; }

        public DateTime UpdateDate { get; set; }

    }
}
