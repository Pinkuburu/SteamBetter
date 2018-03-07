﻿using RiotApiClient.Models;

namespace RiotApiClient.Interfaces
{
    public interface IRiotGamesApi
    {
        SummonerModel GetSummoner(string name);
        ChampionModel GetChamions();
        GamesModel GetFeaturedGames();
        ChardStatusModel GetShardStatus();
    }
}