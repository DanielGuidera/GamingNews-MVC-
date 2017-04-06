using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DemoMVC.Data_Access_Layer
{
    public class ArticleContext : DbContext
    {
        public ArticleContext() : base("ArticleContext")
        {
        }

        public DbSet<ArticleModels> Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}