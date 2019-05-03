using BloodDonation.PagedLists;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Components
{
    public class DonationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(DonationPagedList donationList)
        {
            return View(donationList);
        }
    }
}
