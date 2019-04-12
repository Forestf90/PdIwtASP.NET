using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            String url = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL";

            XElement rss = XElement.Load(url);

            var queryLambda = rss.Descendants("item").Select(item =>
                        new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        });
            var items = queryLambda.ToList();

            String url2 = "https://www.tvn24.pl/najnowsze.xml";

            XElement rss2 = XElement.Load(url2);

            var queryLambda2 = rss2.Descendants("item").Select(item =>
                        new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        });
            var items2 = queryLambda2.ToList();

            String url3 = "https://fakty.interia.pl/religia/feed";

            XElement rss3 = XElement.Load(url3);

            var queryLambda3 = rss3.Descendants("item").Select(item =>
                        new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        });
            var items3 = queryLambda3.ToList();


            String url4 = "https://sport.interia.pl/koszykowka/feed";

            XElement rss4 = XElement.Load(url4);

            var queryLambda4 = rss4.Descendants("item").Select(item =>
                        new RssItem
                        {
                            Title = item.Element("title").Value,
                            pubDate = item.Element("pubDate").Value,
                            Description = item.Element("description").Value
                        });
            var items4 = queryLambda4.ToList();


            Random rnd = new Random();
            int r = rnd.Next(items.Count);
            var item1 = items[r];

            r = rnd.Next(items2.Count);
            var item2 = items2[r];

            r = rnd.Next(items3.Count);
            var item3 = items3[r];

            r = rnd.Next(items4.Count);
            var item4 = items4[r];

            var items5 =new List<RssItem>();
            items5.Add(item1);
            items5.Add(item2);
            items5.Add(item3);
            items5.Add(item4);


            return View(items5);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}