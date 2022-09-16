using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class SyteDbContext : IdentityDbContext<User>
    {
        public SyteDbContext(DbContextOptions<SyteDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Deals> Deals{ get; set; }
        public DbSet<ContactForm> ContactForms{ get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<OurStores> OurStores { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<BlogReview> BlogReviews { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<MyTeam> MyTeams{ get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<WhoWeAre> whoWeAres { get; set; }
        public DbSet<Fabrica> Fabricas { get; set; }
        public DbSet<FaqTitle> FaqTitles { get; set; }
        public DbSet<FaqComponent> FaqComponents { get; set; }
        public DbSet<ProductsToColors> ProductsToColors { get; set; }
        public DbSet<ProductPictureGallery> ProductPictureGalleries{ get; set; }
        public DbSet<SizeToProduct> SizeToProducts{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //one to many
            modelBuilder.Entity<Product>()
               .HasOne(a => a.category)
               .WithMany(b => b.Products)
               .HasForeignKey(a => a.CategoryId);

            modelBuilder.Entity<Sales>()
             .HasOne(a => a.User)
             .WithMany(b => b.Sales)
             .HasForeignKey(a => a.UserId);

            modelBuilder.Entity<Sales>()
              .HasOne(a => a.Product)
              .WithMany(b => b.sales)
              .HasForeignKey(a => a.ProductId);

            modelBuilder.Entity<FaqComponent>()
              .HasOne(a => a.FaqTitle)
              .WithMany(b => b.faqComponents)
              .HasForeignKey(a => a.FaqTitleId);

            modelBuilder.Entity<BlogReview>()
               .HasOne(a => a.Blog)
               .WithMany(b => b.BlogReviews)
               .HasForeignKey(a => a.BlogId);

            modelBuilder.Entity<Blog>()
               .HasOne(a => a.category)
               .WithMany(b => b.Blogs)
               .HasForeignKey(a => a.CategoryId);

            //modelBuilder.Entity<ProductPictureGallery>()
            //   .HasOne(a => a.Product)
            //   .WithMany(b => b.ProductPictureGalleries)
            //   .HasForeignKey(a => a.ProductId);

            //many to many
            modelBuilder.Entity<ProductsToColors>()
              .HasOne(a => a.Product)
              .WithMany(b => b.ProductsToColors)
              .HasForeignKey(a => a.ProductId);

            modelBuilder.Entity<ProductsToColors>()
              .HasOne(a => a.color)
              .WithMany(b => b.ProductsToColors)
              .HasForeignKey(a => a.colorId);

            modelBuilder.Entity<ProductsToColors>()
                .HasKey(bc => new { bc.ProductId, bc.colorId });


            modelBuilder.Entity<SizeToProduct>()
             .HasOne(a => a.Product)
             .WithMany(b => b.SizeToProducts)
             .HasForeignKey(a => a.ProductId);

            modelBuilder.Entity<SizeToProduct>()
              .HasOne(a => a.Size)
              .WithMany(b => b.SizeToProducts)
              .HasForeignKey(a => a.SizeId);

            modelBuilder.Entity<SizeToProduct>()
                .HasKey(bc => new { bc.ProductId, bc.SizeId });
        }
    }
}
