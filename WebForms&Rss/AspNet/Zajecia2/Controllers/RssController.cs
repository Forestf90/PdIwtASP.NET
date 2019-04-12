using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Zajecia2.Models;

namespace Zajecia2.Controllers
{
    public class RssController : Controller
    {
        // GET: Rss
        public ActionResult Index()
        {
            // String url = txtUrl.Text;
            //string url = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL";
            String url = "";
            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL";
            }

            XElement rss = XElement.Load(url);


            /*
            var query = from item in rss.Descendants("item")
                        select new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        };

                        */

            var queryLambda = rss.Descendants("item").Select(item =>
                        new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        });
            var items = queryLambda.ToList();
            var items2 = new List<RssItem>();
            var items3 = new List<RssItem>();
            int kk = 0;
            foreach (RssItem r in items)
            {
                if (kk % 2 == 0) items2.Add(r);
                else items3.Add(r);
                kk++;
            }
            return View(items); ;
        }
    }
}