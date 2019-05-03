using BloodDonation.Enums;
using PESEL.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Models
{


    public class Donor
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        //[Pesel]
        [RegularExpression(@"[0-9]{11}")]
        public string Pesel { get; set; }
        public Gender Gender { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public BloodRhFactor Rh { get; set; }
        public ICollection<Donation> Donations { get; set; }

        public Donor()
        {
            Donations = new HashSet<Donation>();
        }

        public string GetHonor()
        {
            int amount = Donations.Select(a => a.GetAmount()).Sum();

            if (Gender == Gender.Female)
            {
                if (amount >= 15000) return "/images/odznaki/I.png";
                else if(amount >=10000) return "/images/odznaki/II.png";
                else if(amount >=5000) return "/images/odznaki/III.png";
                else return "";
            }
            else
            {
                if (amount >= 18000) return "/images/odznaki/I.png";
                else if (amount >= 12000) return "/images/odznaki/II.png";
                else if (amount >= 6000) return "/images/odznaki/III.png";
                else return "";
            }

        }
    }
}
