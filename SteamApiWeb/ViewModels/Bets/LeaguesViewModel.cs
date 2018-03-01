namespace SteamBetterWeb.ViewModels.Bets
{
    public class LeaguesViewModel
    {
        public int SportId { get; set; }

        public League[] Leagues { get; set; }

        public class League
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string HomeTeamType { get; set; }
            public bool HasOfferings { get; set; }
            public string Container { get; set; }
            public bool AllowRoundRobins { get; set; }
            public int LeagueSpecialsCount { get; set; }
            public int EventSpecialsCount { get; set; }
            public int EventCount { get; set; }
        }

    }
}