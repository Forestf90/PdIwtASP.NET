using BloodDonation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{


    public class Donor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public Gender Gender { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public BloodRhFactor Rh { get; set; }
        public HonorDonor Honor { get; set; }
        public ICollection<Donation> Donations { get; set; }

        public Donor()
        {
            Donations = new HashSet<Donation>();
        }
    }
}
