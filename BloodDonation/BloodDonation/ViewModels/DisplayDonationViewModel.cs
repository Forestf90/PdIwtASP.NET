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
        public string BloodType { get; set; }
        public DonationType DonationType { get; set; }
        public DateTime Date { get; set; }
    }
}
