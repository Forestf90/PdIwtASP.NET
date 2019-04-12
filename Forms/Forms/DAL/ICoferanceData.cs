using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.DAL
{
    public interface IConferenceData
    {
        IEnumerable<ConferenceUser> GetSavedUsers();
        void SaveUser(ConferenceUser conferenceUser);

    }
}
