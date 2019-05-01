using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Models;
using BloodDonation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    public class DonorController : Controller
    {
        private DonationContext _context = new DonationContext();
        // GET: Donor
        public ActionResult Index()
        {
            var donorViewModel = _context.Donors.Select(n =>new DisplayDonorViewModel
            {
                Pesel= n.Pesel,
                FirstName=n.FirstName,
                LastName=n.LastName,
                Gender =n.Gender,
                BloodType = "/images/blood_groups/"+n.BloodGroup.ToString()
                                                    +n.Rh.ToString()+".png",
                Badge= "/images/odznaki/"+n.Honor.ToString()+".png",
                DonationGiven = n.Donations.Select(k=> k.Amount).Sum()
            });
            donorViewModel =donorViewModel.Take(10);
            return View(donorViewModel);
        }

        // GET: Donor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donor/Create
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