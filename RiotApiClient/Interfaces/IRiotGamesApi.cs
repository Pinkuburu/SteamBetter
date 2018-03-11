using RiotApiClient.Models;

namespace RiotApiClient.Interfaces
{
    public interface IRiotGamesApi
    {
        SummonerModel GetSummoner(string name);
        ChampionModel GetChampions();
        GamesModel GetFeaturedGames();
        ChardStatusModel GetShardStatus();
        StaticChampionModel GetStaticChampions();
    }
}