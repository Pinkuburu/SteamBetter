// ReSharper disable InconsistentNaming

namespace ConsolePinnacle.Models
{
    public class SportsModel
    {
        public Sport[] sports { get; set; }

        public class Sport
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool hasOfferings { get; set; }
            public int leagueSpecialsCount { get; set; }
            public int eventSpecialsCount { get; set; }
            public int eventCount { get; set; }
        }

    }
}