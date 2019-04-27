using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{
    public enum BloodGroup
    {
        O,
        A, 
        B, 
        AB
    }

    public enum BloodRhFactor
    {
       Negative,
       Positive
    }


    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public BloodRhFactor Rh { get; set; }
        public ICollection<Donation> Donations { get; set; }

        public Client()
        {
            Donations = new HashSet<Donation>();
        }
    }
}
