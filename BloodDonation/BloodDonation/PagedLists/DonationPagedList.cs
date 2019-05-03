using BloodDonation.Models;
using BloodDonation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.PagedLists
{
    public class DonationPagedList
    {
        public List<DisplayDonationViewModel> GetDonations { get; set; }
        public Donation Donation { get; set; }
        public DisplayDonationViewModel DisplayDonation { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsOnPage { get; set; }
    }
}
