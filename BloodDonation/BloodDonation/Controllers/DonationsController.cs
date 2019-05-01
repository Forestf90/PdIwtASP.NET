using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Enums;
using BloodDonation.Models;
using BloodDonation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    public class DonationsController : Controller
    {
        private static DonationContext _context = new DonationContext(); 
        // GET: Donations
        public ActionResult Index()
        {
            var donationViewModel = _context.Donations.Select(n => new DisplayDonationViewModel
            {
                Pesel = n.Donor.Pesel,

                BloodType = "/images/blood_groups/" + n.Donor.BloodGroup.ToString()
                                         + n.Donor.Rh.ToString() + ".png",
                Amount = n.Amount,
                Data= n.Date
            });
            donationViewModel = donationViewModel.Take(10);

            return View(donationViewModel);
        }

       
        // GET: Donations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
    }
}