using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlaInstagram.Models
{
    public class InstagramContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }


        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
            .Property(e => e.PhotosPath)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            modelBuilder.Entity<PostTag>()
                        .HasKey(pt => new { pt.Id });

            //modelBuilder.Entity<PostTag>()
            //            .HasOne(pt => pt.Tag)
            //            .WithMany(t => t.PostTag)
            //            .HasForeignKey(pt => pt.TagId);

            //modelBuilder.Entity<PostTag>()
            //            .HasOne(pt => pt.Post)
            //            .WithMany(p => p.PostTag)
            //            .HasForeignKey(pt => pt.PostId);
        }
    }
}
