namespace SteamBetterWeb.ViewModels.Games
{
    public class TeamInfoViewModel
    {
        public Results result { get; set; }

        public class Results
        {
            public int status { get; set; }
            public Team[] teams { get; set; }
        }

        public class Team
        {
            public string name { get; set; }
            public string tag { get; set; }
            public int time_created { get; set; }
            public int calibration_games_remaining { get; set; }
            public long logo { get; set; }
            public long logo_sponsor { get; set; }
            public string country_code { get; set; }
            public string url { get; set; }
            public int games_played { get; set; }
            public int player_0_account_id { get; set; }
            public int admin_account_id { get; set; }
        }

    }
}