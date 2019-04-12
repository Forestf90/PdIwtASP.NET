using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Components.Demo2.Components
{
    public class TechnologiesViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(int noItems)
        {
            var technologies = new List<string> { "asp core", "django", "Flatter", "react.js", "vus.js" };
            return View(technologies.Take(noItems).ToList());
        }
    }
}
