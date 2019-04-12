using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebForsmsDemo.Model;

namespace WebForsmsDemo
{
    public partial class RSSReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BtnGet_Click(sender, e);
        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {

            string url = txtUrl.Text;
            //string url = "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL";

            if (string.IsNullOrWhiteSpace(url))
            {
               url= "https://news.google.com/rss?hl=pl&gl=PL&ceid=PL";
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
            foreach( RssItem r in items)
            {
                if (kk % 2 == 0) items2.Add(r);
                else items3.Add(r);
                kk++;
            }
            Repeater1.DataSource = items2;
            Repeater1.DataBind();

            Repeater2.DataSource = items3;
            Repeater2.DataBind();
        }
    }
}