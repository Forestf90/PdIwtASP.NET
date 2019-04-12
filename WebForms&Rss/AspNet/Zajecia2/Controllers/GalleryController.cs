using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zajecia2.Models;

namespace Zajecia2.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {

            //pobrac jsona
            //zamienic jsona na swiat obiektow
            //dodac widok przekazujac odpowiedni model

            WebClient wc = new WebClient();
            String url = "https://api.unsplash.com/photos/?page=1&client_id=3dd7fa37ed3bb1bd0cb7ac54a5f2941d2b18152277e74f4a5c1d7c3deacb4496";
            var json = wc.DownloadString(url);
            var apiresponse = JsonConvert.DeserializeObject<List<ApiResponds>>(json);
            var images = apiresponse.Select(n => new ImageModel
            {
                ThumbUrl = n.urls.thumb,
                RegularUrl = n.urls.regular
            }).ToList();

            return View(images);
            //return View();
        }
    }
}