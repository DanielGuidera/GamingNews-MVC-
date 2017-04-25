using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoMVC.Models;
using System.Data.Entity;

namespace DemoMVC.Data_Access_Layer
{
    public class SiteContext : DbContext
    {
        public SiteContext() : base("SiteContext")
        {

        }
        public DbSet<ArticleModels> Articles { get; set; }
        public DbSet<ReportModel> Reports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}