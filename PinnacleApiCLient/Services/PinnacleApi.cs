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


        private string _balanceUrl = "https://api.pinnacle.com/v1/client/balance";
        private readonly string _sportsUrl = "https://api.pinnacle.com/v2/sports";
        private readonly string _leaguesUrl = "https://api.pinnacle.com/v2/leagues?sportId={0}";
        private string _oddsUrl = "https://api.pinnacle.com/v1/odds?sportId={0}";
        private string _straightBetsUrl = "https://api.pinnacle.com/v2/bets/straight";

        public SportsModel GetSports()
        {
            var url = string.Format(_sportsUrl);
            var uri = new Uri(url);

            return WebGet<SportsModel>(uri);
        } 
        
        public LeaguesModel GetLeaguesForSport(int sportId)
        {
            var url = string.Format(_leaguesUrl, sportId);
            var uri = new Uri(url);

            return WebGet<LeaguesModel>(uri);
        }

        public OddsModel GetOddsForSports(int sportId)
        {
            var url = string.Format(_oddsUrl, sportId);
            var uri = new Uri(url);

            return WebGet<OddsModel>(uri);
        }
    }
}