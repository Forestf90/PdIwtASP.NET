using BloodDonation.Models;
using BloodDonation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.PagedLists
{
    public class DonorPagedList
    {
        public List<DisplayDonorViewModel> GetDonors { get; set; }
        public Donor Donor { get; set; }
        public DisplayDonorViewModel DisplayDonor { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsOnPage { get; set; }
    }
}
