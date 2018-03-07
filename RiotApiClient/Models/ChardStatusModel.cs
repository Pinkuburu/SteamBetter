// ReSharper disable InconsistentNaming

using System;

namespace RiotApiClient.Models
{
    public class ChardStatusModel
    {

        
            public string name { get; set; }
            public string slug { get; set; }
            public string[] locales { get; set; }
            public string hostname { get; set; }
            public string region_tag { get; set; }
           public Service[] services { get; set; }
        

        public class Service
        {
            public string name { get; set; }
            public string slug { get; set; }
            public string status { get; set; }
            public Incident[] incidents { get; set; }
        }

        public class Incident
        {
            public int id { get; set; }
            public bool active { get; set; }
            public DateTime created_at { get; set; }
            public Update[] updates { get; set; }
        }

        public class Update
        {
            public string id { get; set; }
            public string author { get; set; }
            public string content { get; set; }
            public string severity { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public object[] translations { get; set; }
        }



    }
}