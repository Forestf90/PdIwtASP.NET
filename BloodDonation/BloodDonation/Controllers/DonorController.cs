using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Enums;
using BloodDonation.Models;
using BloodDonation.PagedLists;
using BloodDonation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloodDonation.Controllers
{
    public class DonorController : Controller
    {
        private DonationContext _context = new DonationContext();

        public DonorPagedList GetPagedList(int page = 1, int itemsOnPage = 10 )
        {
            var donorViewModel = _context.Donors.Select(n => new DisplayDonorViewModel
            {
                Pesel = n.Pesel,
                FirstName = n.FirstName,
                LastName = n.LastName,
                Gender = n.GetGender(),
                BloodType = "/images/blood_groups/" + n.BloodGroup.ToString()
                                                    + n.Rh.ToString() + ".png",
                Badge = n.GetHonor(),
                DonationGiven = n.Donations.Select(k => k.GetAmount()).Sum()
            });


            var pagedList = new DonorPagedList();
            pagedList.CurrentPage = page;
            pagedList.TotalPages = donorViewModel.Count() / itemsOnPage;
            if (donorViewModel.Count() % itemsOnPage > 0)
                pagedList.TotalPages++;
            pagedList.ItemsOnPage = itemsOnPage;

            pagedList.GetDonors = new List<DisplayDonorViewModel>();
            pagedList.GetDonors = donorViewModel.Skip((page - 1) * itemsOnPage)
                .Take(itemsOnPage).ToList();

            return pagedList;
        }
        // GET: Donor
        public ActionResult Index(int page = 1, int itemsOnPage = 10)
        {

            return View(GetPagedList(page , itemsOnPage));
        }

        // GET: Donor/Create
        public ActionResult Create(int page = 1, int itemsOnPage = 5, bool? add = null)
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

            if (add!=null){
                if ((bool)add) ViewData["DonorCreate"] = true;
                else ViewData["DonorCreate"] = false;
            }
            

            return View(GetPagedList(page, itemsOnPage));
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
                        return RedirectToAction(nameof(Create) , new {add=false });
                    }
                    else
                    {
                        _context.AddDonor(donor);

                        return RedirectToAction(nameof(Create) , new { add = true });
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