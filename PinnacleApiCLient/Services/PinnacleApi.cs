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


        private const string _balanceUrl = "https://api.pinnacle.com/v1/client/balance";

        private const string _sportsUrl = "https://api.pinnacle.com/v2/sports";
        private const string _leaguesUrl = "https://api.pinnacle.com/v2/leagues?sportId={0}";
        private const string _oddsSportUrl = "https://api.pinnacle.com/v1/odds?sportId={0}";
        private const string _oddsEventUrl = "https://api.pinnacle.com/v1/odds?sportId={0}&eventIds={1}";
        private const string _fixturesUrl = "https://api.pinnacle.com/v1/fixtures?sportId={0}";
        private const string _linesUrl = "https://api.pinnacle.com/v1/line?sportId={0}&leagueId={1}&eventId={2}&team=Team1&betType=MONEYLINE&oddsFormat=Decimal&periodNumber=0";


        private const string _straightBetsUrl = "https://api.pinnacle.com/v2/bets/straight";

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
        
        public OddsModel GetOddsForSport(int sportId)
        {
            var url = string.Format(_oddsSportUrl, sportId);
            var uri = new Uri(url);

            return WebGet<OddsModel>(uri);
        }

        public OddsModel GetOddsForEvent(int sportId, int eventId)
        {
            var url = string.Format(_oddsEventUrl, sportId, eventId);
            var uri = new Uri(url);

            return WebGet<OddsModel>(uri);
        }

        public FixturesModel GetFixturesForSportLeague(int sportId, int leagueId)
        {
            var url = string.Format(_fixturesUrl, sportId, leagueId);
            var uri = new Uri(url);

            return WebGet<FixturesModel>(uri);
        }

        public LinesModel GetLinesForEvent(int sportId, int leagueId, int eventId)
        {
            var url = string.Format(_linesUrl, sportId, leagueId, eventId);
            var uri = new Uri(url);

            return WebGet<LinesModel>(uri);
        }
    }
}