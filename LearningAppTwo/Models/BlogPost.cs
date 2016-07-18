using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningAppTwo.Models
{
    public class BlogPost
    {
        public int BlogPostID { get; set; }
        public string BlogPostTitle { get; set; }
        public string BlogPostContent { get; set; }
        public DateTime BlogPostDate { get; set; }
    }
}