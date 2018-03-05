using System;
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

        private readonly string _apiKey;

        public SummonerModel GetSummoner(string name)
        {
            var url = string.Format(SummonerUrl, name, _apiKey);
            var uri = new Uri(url);

            return WebGet<SummonerModel>(uri);
        }
    }
}
