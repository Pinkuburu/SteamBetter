using System;
using PinnacleApiClient.Interfaces;
using PinnacleApiClient.Models;

namespace PinnacleApiClient.Services
{
    public class PinnacleApi : ApiBase, IPinnacleApi
    {
        public PinnacleApi(string token) : base(token)
        {
        }


        private string _baslanceUrl1 = "https://api.pinnacle.com/v1/client/balance";
        private readonly string _sportsUrl = "https://api.pinnacle.com/v2/sports";
        private readonly string _leaguesUrl = "https://api.pinnacle.com/v2/leagues?sportId=12";
        private string _oddsUrl = "https://api.pinnacle.com/v1/odds?sportId=12";
        private string _straigtBetsUrl = "https://api.pinnacle.com/v2/bets/straight";

        public SportsModel GetSports()
        {
            var url = string.Format(_sportsUrl);
            var uri = new Uri(url);

            return WebGet<SportsModel>(uri, nameof(_sportsUrl));
        } 
        
        public LeaguesModel GetLeagues()
        {
            var url = string.Format(_leaguesUrl);
            var uri = new Uri(url);

            return WebGet<LeaguesModel>(uri, nameof(_leaguesUrl));
        }
    }
}