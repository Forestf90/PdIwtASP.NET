using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;
using Newtonsoft.Json;

namespace Forms.DAL
{
    public class EntityConferenceData : IConferenceData , IDisposable
    {


        public ConferenceContext conferenceContext;

        public EntityConferenceData()
        {
            conferenceContext = new ConferenceContext();
            conferenceContext.Database.EnsureCreated();

            if (conferenceContext.ConferenceUsers.Count() == 0)
            {
                using (StreamReader r = new StreamReader(Path.Combine(".", "MOCK_DATA.json")))
                {
                    string jsonn = r.ReadToEnd();
                    List<ConferenceUser> items = JsonConvert.DeserializeObject<List<ConferenceUser>>(jsonn);

                    foreach (ConferenceUser k in items)
                    {
                        SaveUser(k);
                    }
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ConferenceUser> GetSavedUsers()
        {

            //context.Database.EnsureCreated();

            return conferenceContext.ConferenceUsers;

        }

        public void SaveUser(ConferenceUser conferenceUser)
        {

            //context.Database.EnsureCreated();
            conferenceContext.ConferenceUsers.Add(conferenceUser);
            conferenceContext.SaveChanges();

        }
    }
}

