﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSite.Models
{
    public class SyteDbContext : DbContext
    {
        public SyteDbContext(DbContextOptions<SyteDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Size> sizes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<MyTeam> MyTeams{ get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<WhoWeAre> whoWeAres { get; set; }
        public DbSet<Fabrica> Fabricas { get; set; }
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
