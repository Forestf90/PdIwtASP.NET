using BloodDonation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.ViewModels
{
    public class DisplayDonationViewModel
    {
        public string Pesel { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public BloodRhFactor Rh { get; set; }
        public int Amount { get; set; }
        public DateTime Data { get; set; }
    }
}
