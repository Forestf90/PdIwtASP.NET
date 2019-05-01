using BloodDonation.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{
    public class DonationContext : DbContext
    {
        DbSet<Donor> Donors { get; set; }
        DbSet<Donation> Donations { get; set; }

        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Donor>()
                        .HasKey(pt => new { pt.Pesel });
        }
        public DonationContext() 
        {
            Database.EnsureCreated();
            if (!Donors.Any() && !Donations.Any())
            {
                using (StreamReader rd = new StreamReader("source4.csv"))
                {
                    while (!rd.EndOfStream)
                    {
                        var line = rd.ReadLine();
                        var values = line.Split(',');

                        Donor temp = new Donor
                        {
                            FirstName = values[0],
                            LastName = values[1],
                            Pesel = values[2],
                            Gender =(Gender)Convert.ToInt32(values[3]),
                            BloodGroup = (BloodGroup)Convert.ToInt32(values[4]),
                            Rh = (BloodRhFactor)Convert.ToInt32(values[5]),
                            Honor = (HonorDonor)Convert.ToInt32(values[6])



                        };
                        //AddDonor(temp);
                        AddDonation(new Donation
                        {
                            Donor = temp,
                            Amount = Convert.ToInt32(values[7]),
                            Date = DateTime.ParseExact(values[8], "MM/dd/yyyy", null)
                        });
                    }
                }
            }
        }


        public void AddDonor(Donor donor)
        {
            Donors.Add(donor);
            SaveChanges();
        }
            
        public void AddDonation(Donation donation)
        {
            Donations.Add(donation);
            SaveChanges();
        }

    }
}
