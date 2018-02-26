﻿using System;

namespace SteamBetterWeb.ViewModels.Bets
{
    public class FixturesViewModel
    {
        public int sportId { get; set; }
        public int last { get; set; }
        public League[] league { get; set; }

        public class League
        {
            public int id { get; set; }
            public string name { get; set; }
            public Event[] events { get; set; }
        }

        public class Event
        {
            public int id { get; set; }
            public DateTime starts { get; set; }
            public string home { get; set; }
            public string away { get; set; }
            public string rotNum { get; set; }
            public int liveStatus { get; set; }
            public string status { get; set; }
            public int parlayRestriction { get; set; }
        }

    }
}