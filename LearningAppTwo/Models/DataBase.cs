using LearningAppTwo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LearningAppTwo.Models
{
    public class DataBase
    {
        public List<BlogPost> GetBlogs()
        {
            using (DataContext dataContext = new DataContext())
            {
                List<BlogPost> posts = new List<BlogPost>();
                
                foreach (var item in dataContext.Blogs)
                {
                    BlogPost post = new BlogPost();
                    post.BlogPostID = item.Id;
                    post.BlogPostTitle = item.BlogTitle;
                    post.BlogPostContent = item.BlogContent;
                    post.BlogPostDate = item.BlogPostDate;

                    posts.Add(post); 
                }

                return posts;
            }
        }
    }
}