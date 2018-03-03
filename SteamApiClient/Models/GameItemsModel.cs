// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class GameItemsModel
    {
        public Results result { get; set; }

        public class Results
        {
            public Item[] items { get; set; }
            public int status { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
            public int cost { get; set; }
            public int secret_shop { get; set; }
            public int side_shop { get; set; }
            public int recipe { get; set; }
        }

    }
}