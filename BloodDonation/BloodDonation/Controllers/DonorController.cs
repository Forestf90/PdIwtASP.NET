using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Enums;
using BloodDonation.Models;
using BloodDonation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
                //Badge= "/images/odznaki/"+n.Honor.ToString()+".png",
                Badge = n.GetHonor(),
                DonationGiven = n.Donations.Select(k=> k.Amount).Sum()
            });
            donorViewModel =donorViewModel.Take(10);
            return View(donorViewModel);
        }

        // GET: Donor/Create
        public ActionResult Create()
        {
            var selectListGender = new List<SelectListItem>
            {
                new SelectListItem{Value = Gender.Male.ToString() , Text="Mężczyzna"},
                new SelectListItem{Value = Gender.Female.ToString() , Text="Kobieta"},
            };
            ViewBag.Gender = selectListGender;

            var selectListBloodGroup = new List<SelectListItem>
            {
                new SelectListItem{ Value=BloodGroup.Zero.ToString() , Text="0"},
                new SelectListItem{ Value=BloodGroup.A.ToString() , Text="A"},
                new SelectListItem{ Value=BloodGroup.B.ToString() , Text="B"},
                new SelectListItem{ Value=BloodGroup.AB.ToString() , Text="AB"}
            };
            ViewBag.BloodGroup = selectListBloodGroup;

            var selectListRh = new List<SelectListItem>
            {
                new SelectListItem{Value = BloodRhFactor.Positive.ToString() , Text="+"},
                new SelectListItem{Value = BloodRhFactor.Negative.ToString() , Text="-"},
            };
            ViewBag.BloodRh = selectListRh;

            ViewData["DonorCreate"] = true;

            return View();
        }

        // POST: Donor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Donor donor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var exist = _context.Donors.Where(p => p.Pesel == donor.Pesel).Any();
                    if (exist)
                    {
                        ViewData["DonorCreate"] = false;
                        return RedirectToAction(nameof(Create));
                    }
                    else
                    {
                        _context.AddDonor(donor);

                        ViewData["DonorCreate"] = true;
                        return RedirectToAction(nameof(Create));
                    }

                }
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