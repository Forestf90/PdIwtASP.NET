using BloodDonation.PagedLists;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.Components
{
    public class DonorViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke(DonorPagedList donorList)
        {
            return View(donorList);
        }
    }
}
