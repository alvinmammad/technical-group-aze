using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnicalGroup.Models;
using TechnicalGroup.Areas.TechnicalGroupAdmin.Models;

namespace TechnicalGroup.Data
{
    public class TechnicalGroupDbContext:DbContext
    {
        

        public TechnicalGroupDbContext(DbContextOptions<TechnicalGroupDbContext> options):base(options)
        {
            
        }
        public DbSet<AboutItems> AboutItems { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Facts> Facts { get; set; }
        public DbSet<Post> Posts { get; set; }
       
        public DbSet<PostWriter> PostWriters { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPhotos> ProductPhotos { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProjectPhotos> ProjectPhotos { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ServiceItems> ServiceItems { get; set; }
        public DbSet<Settings> Settings { get; set; }
       
        public DbSet<WhyChooseUsItems> WhyChooseUsItems { get; set; }
        public DbSet<HomeAboutItems> HomeAboutItems { get; set; }
        #region Admin
        public DbSet<Admin> Admin { get; set; }
        #endregion

    }
}
