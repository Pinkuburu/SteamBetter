
namespace SteamBetterWeb.ViewModels.Economy
{
    public class HeroesModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public Hero[] Heroes { get; set; }
            public int Status { get; set; }
            public int Count { get; set; }
        }

        public class Hero
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }

    }
}