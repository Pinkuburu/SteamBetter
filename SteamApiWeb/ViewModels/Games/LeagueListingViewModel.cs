
namespace SteamBetterWeb.ViewModels.Games
{
    public class LeagueListingViewModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public League[] Leagues { get; set; }
        }

        public class League
        {
            public string Name { get; set; }
            public int Leagueid { get; set; }
            public string Description { get; set; }
            public string TournamentUrl { get; set; }
            public int Itemdef { get; set; }
        }

    }
}