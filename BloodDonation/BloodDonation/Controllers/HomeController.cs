using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BloodDonation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloodDonation.Controllers
{

    //imie nazwisko pesel , data donacji , grupa krwei , czynniki , ilość , 
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DonationContext context = new DonationContext();


            var tmpDic = new Dictionary<float, string>
            {
                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.Zero &&
                         g.Donor.Rh==Enums.BloodRhFactor.Positive)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/ZeroPositive.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.A &&
                         g.Donor.Rh==Enums.BloodRhFactor.Positive)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/APositive.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.B &&
                         g.Donor.Rh==Enums.BloodRhFactor.Positive)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/BPositive.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.AB &&
                         g.Donor.Rh==Enums.BloodRhFactor.Positive)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/ABPositive.png" },


                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.Zero &&
                         g.Donor.Rh==Enums.BloodRhFactor.Negative)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/ZeroNegative.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.A &&
                         g.Donor.Rh==Enums.BloodRhFactor.Negative)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/ANegative.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.B &&
                         g.Donor.Rh==Enums.BloodRhFactor.Negative)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/BNegative.png" },

                { (float)context.Donations.Where(g=>g.Donor.BloodGroup==Enums.BloodGroup.AB &&
                         g.Donor.Rh==Enums.BloodRhFactor.Negative)
                        .Select(a => a.Amount).Sum()/100,"/images/blood_groups/ABNegative.png" }
            };



           // amounts = context.Donations.
            return View(tmpDic);
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
