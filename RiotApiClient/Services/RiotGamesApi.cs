﻿using System;
using RiotApiClient.Interfaces;
using RiotApiClient.Models;

namespace RiotApiClient.Services
{
    public class RiotGamesApi: ApiBase, IRiotGamesApi
    {
        public RiotGamesApi(string apiKey) 
        {
            _apiKey = apiKey;
        }

        private const string SummonerUrl = "https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/{0}?api_key={1}";
        private const string ChampionsUrl = "https://na1.api.riotgames.com/lol/platform/v3/champions/?api_key={0}";
        private const string FeaturedGamesUrl = "https://na1.api.riotgames.com/lol/spectator/v3/featured-games/?api_key={0}";
        private const string TournamentGamesUrl = "https://na1.api.riotgames.com/lol/match/v3/matches/by-tournament-code/{tournamentCode}/ids/?api_key={1}";
        private const string ShardStatusUrl = "https://na1.api.riotgames.com/lol/status/v3/shard-data/?api_key={0}";
        
         
        private readonly string _apiKey;

        public SummonerModel GetSummoner(string name)
        {
            var url = string.Format(SummonerUrl, name, _apiKey);
            var uri = new Uri(url);

            return WebGet<SummonerModel>(uri);
        }

        public ChampionModel GetChamions()
        {
            var url = string.Format(ChampionsUrl, _apiKey);
            var uri = new Uri(url);

            return WebGet<ChampionModel>(uri);
        }

        public GamesModel GetFeaturedGames()
        {
            var url = string.Format(FeaturedGamesUrl, _apiKey);
            var uri = new Uri(url);

            return WebGet<GamesModel>(uri);
        }

        public ChardStatusModel GetShardStatus()
        {
            var url = string.Format(ShardStatusUrl, _apiKey);
            var uri = new Uri(url);

            return WebGet<ChardStatusModel>(uri);
        }
    }
}
