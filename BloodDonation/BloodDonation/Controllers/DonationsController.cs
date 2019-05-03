using System;
using System.Collections.Generic;
using System.IO;
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
    public class DonationsController : Controller
    {
        private static DonationContext _context = new DonationContext();

        public DonationPagedList GetPagedList(int page = 1, int itemsOnPage = 10)
        {
            var donationViewModel = _context.Donations.Select(n => new DisplayDonationViewModel
            {
                Pesel = n.Donor.Pesel,
                BloodType = "/images/blood_groups/" + n.Donor.BloodGroup.ToString()
                                                    + n.Donor.Rh.ToString() + ".png",
                Date=n.Date,
                DonationType = n.DonationType
            });


            var pagedList = new DonationPagedList();
            pagedList.CurrentPage = page;
            pagedList.TotalPages = donationViewModel.Count() / itemsOnPage;
            if (donationViewModel.Count() % itemsOnPage > 0)
                pagedList.TotalPages++;
            pagedList.ItemsOnPage = itemsOnPage;

            pagedList.GetDonations = new List<DisplayDonationViewModel>();
            pagedList.GetDonations = donationViewModel.Skip((page - 1) * itemsOnPage)
                .Take(itemsOnPage).ToList();

            return pagedList;
        }
        // GET: Donations
        public ActionResult Index(int page = 1, int itemsOnPage = 10)
        {

            return View(GetPagedList(page ,itemsOnPage));
        }

       
        // GET: Donations/Create
        public ActionResult Create(int page = 1, int itemsOnPage = 5)
        {
            var selectListDonation = new List<SelectListItem>
            {
                new SelectListItem{Value = DonationType.PureBlood.ToString() , Text="Pełna krew [450ml]"},
                new SelectListItem{Value = DonationType.Plasma.ToString() , Text="Osocze [650ml]"},
                new SelectListItem{Value = DonationType.Platelets.ToString() , Text="Płytki krwi [300ml]"},
                new SelectListItem{Value = DonationType.RedBloodCells.ToString() , Text="Krwinki czerwone [2x300ml]"},
                new SelectListItem{Value = DonationType.WhiteBloodCells.ToString() , Text="Krwinki białe [200ml]"},
            };
            ViewBag.DonationType = selectListDonation;

            var donors = _context.Donors.Select(p => p.Pesel);
            ViewBag.Pesels = donors;

            return View(GetPagedList(page, itemsOnPage));
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