using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forms.Models;
using Newtonsoft.Json;

namespace Forms.DAL
{
    public class JsonConferenceData : IConferenceData
    {
        public static List<ConferenceUser> ConferenceUsers { get; private set; }
            = new List<ConferenceUser>();
        public JsonConferenceData()
        {
            if (ConferenceUsers.Count() == 0)
            {
                using (StreamReader r = new StreamReader(Path.Combine(".", "MOCK_DATA2.json")))
                {
                    string jsonn = r.ReadToEnd();
                    List<ConferenceUser> items = JsonConvert.DeserializeObject<List<ConferenceUser>>(jsonn);

                    foreach (ConferenceUser k in items)
                    {
                        ConferenceUsers.Add(k);
                    }
                }
            }
        }


        public IEnumerable<ConferenceUser> GetSavedUsers()
        {
            return ConferenceUsers;
        }

        public void SaveUser(ConferenceUser conferenceUser)
        {
            ConferenceUsers.Add(conferenceUser);
            var json = JsonConvert.SerializeObject(ConferenceUsers);
            using (StreamWriter r = new StreamWriter(".\\MOCK_DATA2.json"))
            {
                r.Write(json);
            }
        }
    }
}
