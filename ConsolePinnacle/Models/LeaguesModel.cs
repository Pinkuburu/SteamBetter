namespace ConsolePinnacle.Models
{
    public class LeaguesModel
    {
        public League[] leagues { get; set; }

        public class League
        {
            public int id { get; set; }
            public string name { get; set; }
            public string homeTeamType { get; set; }
            public bool hasOfferings { get; set; }
            public string container { get; set; }
            public bool allowRoundRobins { get; set; }
            public int leagueSpecialsCount { get; set; }
            public int eventSpecialsCount { get; set; }
            public int eventCount { get; set; }
        }

    }
}