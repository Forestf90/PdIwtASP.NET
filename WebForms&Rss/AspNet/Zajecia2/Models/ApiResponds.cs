using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zajecia2.Models
{
    public class ApiResponds
    {
        public class Urls
        {
            public string regular { get; set; }
            public string thumb { get; set; }
        }
        [JsonProperty(propertyName: "Urls")]
        public Urls urls { get; set; }

    }
}