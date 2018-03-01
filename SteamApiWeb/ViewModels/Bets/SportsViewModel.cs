namespace SteamBetterWeb.ViewModels.Bets
{
    public class SportsViewModel
    {
        public Sport[] Sports { get; set; }

        public class Sport
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public bool HasOfferings { get; set; }
            public int LeagueSpecialsCount { get; set; }
            public int EventSpecialsCount { get; set; }
            public int EventCount { get; set; }
        }

    }
}