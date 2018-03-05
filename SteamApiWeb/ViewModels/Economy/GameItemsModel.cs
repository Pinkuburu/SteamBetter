
namespace SteamBetterWeb.ViewModels.Economy
{
    public class GameItemsModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public Item[] Items { get; set; }
            public int Status { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }
            public int SecretShop { get; set; }
            public int SideShop { get; set; }
            public int Recipe { get; set; }
        }

    }
}