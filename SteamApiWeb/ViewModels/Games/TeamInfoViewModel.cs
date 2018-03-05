namespace SteamBetterWeb.ViewModels.Games
{
    public class TeamInfoViewModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public int Status { get; set; }
            public Team[] Teams { get; set; }
        }

        public class Team
        {
            public string Name { get; set; }
            public string Tag { get; set; }
            public int TimeCreated { get; set; }
            public int CalibrationGamesRemaining { get; set; }
            public long Logo { get; set; }
            public long LogoSponsor { get; set; }
            public string CountryCode { get; set; }
            public string Url { get; set; }
            public int GamesPlayed { get; set; }
            public int Player0AccountId { get; set; }
            public int AdminAccountId { get; set; }
        }

    }
}