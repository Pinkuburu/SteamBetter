using System;

namespace SteamBetterWeb.ViewModels.Bets
{
    public class FixturesViewModel
    {
        public int SportId { get; set; }
        public int Last { get; set; }
        public League[] league { get; set; }

        public class League
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Event[] Events { get; set; }
        }

        public class Event
        {
            public int Id { get; set; }
            public DateTime Starts { get; set; }
            public string Home { get; set; }
            public string Away { get; set; }
            public string RotNum { get; set; }
            public int LiveStatus { get; set; }
            public string Status { get; set; }
            public int ParlayRestriction { get; set; }
        }

    }
}