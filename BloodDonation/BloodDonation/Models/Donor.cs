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
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public BloodGroup BloodGroup { get; set; }
        [Required]
        public BloodRhFactor Rh { get; set; }
        public ICollection<Donation> Donations { get; set; }

        public Donor()
        {
            Donations = new HashSet<Donation>();
        }

        public string GetHonor()
        {
            DonationContext con = new DonationContext();
            int amount = con.Donations.Where(x=>x.Donor.Pesel==this.Pesel).Select(a => a.GetAmount()).Sum();

            if (this.Gender == Gender.Female)
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

        public DateTime NextDonation(DonationType nextType)
        {
            DateTime next = new DateTime();
            DonationContext con = new DonationContext();

            var lastTime = con.Donations.Where(p => p.Donor.Pesel == this.Pesel).Select(l => l.Date).Max();
            var lastType = con.Donations.Where(p => p.Donor.Pesel == this.Pesel && p.Date == lastTime)
                                .Select(x=> x.DonationType).First();

            next =lastTime.AddDays(64);
            return next;

        }
    }
}


    