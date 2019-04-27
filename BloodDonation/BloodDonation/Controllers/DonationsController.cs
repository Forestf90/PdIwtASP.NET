using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BloodDonation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloodDonation.Controllers
{
    public class DonationsController : Controller
    {
        static List<Client> clients = new List<Client>();
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

                    Client temp =new Client
                    {
                        FirstName = values[0],
                        LastName = values[1],
                        Pesel = values[2],
                        BloodGroup = (BloodGroup)Convert.ToInt32(values[3]),
                        Rh = (BloodRhFactor)Convert.ToInt32(values[4]),
                        


                    };
                    clients.Add(temp);
                    donations.Add(new Donation
                    {
                        Client=temp
                        //Amount
                    });
                }
            }

                return View(clients);
        }

        // GET: Donations/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: Donations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Donations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Donations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Donations/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}