
namespace SteamBetterWeb.ViewModels.Economy
{
    public class RaritiesModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public int Count { get; set; }
            public Rarity[] Rarities { get; set; }
            public int Status { get; set; }
        }

        public class Rarity
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public int Order { get; set; }
            public string Color { get; set; }
        }

    }
}