using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Enums;
using BloodDonation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    public class DonationsController : Controller
    {
        static List<Donor> donors = new List<Donor>();
        static List<Donation> donations = new List<Donation>();
        // GET: Donations
        public ActionResult Index()
        {
            using (StreamReader rd = new StreamReader("source2.csv"))
            {
                while (!rd.EndOfStream)
                {
                    var line = rd.ReadLine();
                    var values = line.Split(',');

                    Donor temp =new Donor
                    {
                        FirstName = values[0],
                        LastName = values[1],
                        Pesel = values[2],
                        BloodGroup = (BloodGroup)Convert.ToInt32(values[3]),
                        Rh = (BloodRhFactor)Convert.ToInt32(values[4]),
                        


                    };
                    donors.Add(temp);
                    donations.Add(new Donation
                    {
                        Donor=temp,
                        Amount = Convert.ToInt32(values[5]),
                        //Date=Convert.ToDateTime(values[6]),
                        Date=DateTime.ParseExact(values[6] ,"M/d/yyyy",null)
                    });
                }
            }

                return View(donors);
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