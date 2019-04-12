using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class PagedList
    {
        public List<ConferenceUser> GetConferenceUsers { get; set; }
        public ConferenceUser conferenceUser { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int ItemsOnPage { get; set; }
    }

}

