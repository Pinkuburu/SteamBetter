namespace SteamApiClient.Models
{
    /// <summary>
    /// "https://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1?key={0}",
    /// </summary>
    public class LeagueListingModel
    {
        public Results result { get; set; }

        public class Results
        {
            public League[] leagues { get; set; }
        }

        public class League
        {
            public string name { get; set; }
            public int leagueid { get; set; }
            public string description { get; set; }
            public string tournament_url { get; set; }
            public int itemdef { get; set; }
        }

    }
}