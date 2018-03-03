using SteamApiClient.Models;

namespace SteamApiClient.Interfaces
{
    public interface IEconDota2
    {
        GameItemsModel GetGameItems();
        HeroesModel GetHeroes();
        RaritiesModel GetRarities();
    }
}