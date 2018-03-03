// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class RaritiesModel
    {
        public Results result { get; set; }

        public class Results
        {
            public int count { get; set; }
            public Rarity[] rarities { get; set; }
            public int status { get; set; }
        }

        public class Rarity
        {
            public string name { get; set; }
            public int id { get; set; }
            public int order { get; set; }
            public string color { get; set; }
        }

    }
}