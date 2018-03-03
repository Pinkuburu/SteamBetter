// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class HeroesModel
    {
        public Results result { get; set; }

        public class Results
        {
            public Hero[] heroes { get; set; }
            public int status { get; set; }
            public int count { get; set; }
        }

        public class Hero
        {
            public string name { get; set; }
            public int id { get; set; }
        }

    }
}