using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forms.DAL;
using Forms.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using X.PagedList;



namespace Forms.Controllers
{
    public class ConferenceController : Controller
    {

        private IConferenceData _conferenceData;
        public ConferenceController()
        {
            _conferenceData = new MemoryConferenceData();
            //_conferenceData = new EntityConferenceData();
            //_conferenceData = new JsonConferenceData();


        }

        public void ConferenceTypeToPolish()
        {
            var selectList = new List<SelectListItem>
            {
                new SelectListItem{Value = ConferenceType.Lecture.ToString() , Text="Wykład"},
                new SelectListItem{Value = ConferenceType.Workshop.ToString() , Text="Warsztaty"},
                new SelectListItem{Value = ConferenceType.Discusion.ToString() , Text="Dyskusja"},
            };
            ViewBag.ConfereceType = selectList;
        }
        // GET: Conference
        public ActionResult Index(int page=1 , int itemsOnPage = 10)
        {
            ConferenceTypeToPolish();
            var pagedList = new PagedList();
            pagedList.CurrentPage = page;
            pagedList.TotalPages = _conferenceData.GetSavedUsers().Count() / itemsOnPage;
            if (_conferenceData.GetSavedUsers().Count() % itemsOnPage > 0)
                pagedList.TotalPages++;
            pagedList.ItemsOnPage = itemsOnPage;


            pagedList.GetConferenceUsers = new List<ConferenceUser>();
            pagedList.GetConferenceUsers = _conferenceData.GetSavedUsers().
                Skip((page - 1) * itemsOnPage).Take(itemsOnPage).ToList();

            return View(pagedList);
        }

        // GET: Conference/Create
        public ActionResult Create(int page = 1, int itemsOnPage = 10)
        {
            ConferenceTypeToPolish();


            var pagedList = new PagedList();
            pagedList.CurrentPage = page;
            pagedList.TotalPages = _conferenceData.GetSavedUsers().Count() / itemsOnPage;
            if (_conferenceData.GetSavedUsers().Count() % itemsOnPage>0)
                pagedList.TotalPages++;
            pagedList.ItemsOnPage = itemsOnPage;


            pagedList.GetConferenceUsers = new List<ConferenceUser>();
            pagedList.GetConferenceUsers = _conferenceData.GetSavedUsers().
                Skip((page - 1) * itemsOnPage).Take(itemsOnPage).ToList();

            return View(pagedList);
        }

        // POST: Conference/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConferenceUser conferenceUser , IFormFile file)
        {
            
            try
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\", fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    conferenceUser.Avatar = "/images/"+fileName;
                }
                // TODO: Add insert logic here
                _conferenceData.SaveUser(conferenceUser);
                return RedirectToAction(nameof(Create));
            }
            catch
            {
                return View();
            }
        }

    }
}









//1 dodanie polskich nazw w liscie dodanych
//2 dodanie opcji uplodu avatara wraz z wyswietleniem
//3 skorzystanie mackaroo wygenerowac plik i potraktowac go jako baze danych z której czytamy i do której zapisujemy
//4 formulaz i lista na jednej stronie
//5 pagination po 10 uzytkowników na stronie



