using BloodDonation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.ViewModels
{
    public class DisplayDonorViewModel
    {
        public string Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string BloodType { get; set; }
        public string Badge { get; set; }
        public int DonationGiven { get; set; }

    }
}
