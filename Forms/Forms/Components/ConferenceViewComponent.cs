using Forms.DAL;
using Forms.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Components
{
    public class ConferenceViewComponent : ViewComponent
    {
            
        //private static MemoryConferenceData conferenceUsers= new MemoryConferenceData();


            public IViewComponentResult Invoke(PagedList userList)
            {
                return View(userList);
            }
    }
}
