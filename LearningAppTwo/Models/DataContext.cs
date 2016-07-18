using LearningAppTwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LearningAppTwo 
{
    public class DataContext : DbContext
    {
        public DataContext() : base("BlogConnectionString")
        {
        }

        public DbSet<Blog> Blogs { get; set; }
    }
}