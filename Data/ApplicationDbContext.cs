using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
// Category + Item is my models that I am connecting
using serverSideScripting_Assignment1B.Models;

namespace serverSideScripting_Assignment1B.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Define Model Class so Controllers can access models
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        // override model creating method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // item and category relationship
            builder.Entity<Item>()
                .HasOne(i => i.Category)
                //with many creates one to many type relationship
                .WithMany(c => c.Items)
                .HasForeignKey(i => i.CategoryId)
                .HasConstraintName("FK_Items_CategoryId");
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
