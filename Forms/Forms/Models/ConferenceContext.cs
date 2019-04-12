using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class ConferenceContext :DbContext
    {
 
        public DbSet<ConferenceUser> ConferenceUsers { get; set; }

        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true";
        //private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          

            base.OnConfiguring(optionsBuilder);


            optionsBuilder.UseSqlServer(connectionString);
            //Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True
        }

        public ConferenceContext()
        {
            
        }
     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
      //  {
      //      modelBuilder.Entity<ConferenceUser>().ToTable("CoferenceUsers");
      //  }

    }





}
