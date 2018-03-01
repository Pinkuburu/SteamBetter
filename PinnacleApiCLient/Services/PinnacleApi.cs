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


        private const string BalanceUrl = "https://api.pinnacle.com/v1/client/balance";

        private const string SportsUrl = "https://api.pinnacle.com/v2/sports";
        private const string LeaguesUrl = "https://api.pinnacle.com/v2/leagues?sportId={0}";
        private const string OddsSportUrl = "https://api.pinnacle.com/v1/odds?sportId={0}";
        private const string OddsEventUrl = "https://api.pinnacle.com/v1/odds?sportId={0}&eventIds={1}";
        private const string FixturesUrl = "https://api.pinnacle.com/v1/fixtures?sportId={0}";
        private const string FixturesByLeaguesUrl = "https://api.pinnacle.com/v1/fixtures?sportId={0}&leagueIds={1}";
        private const string LinesUrl = "https://api.pinnacle.com/v1/line?sportId={0}&leagueId={1}&eventId={2}&team=Team1&betType=MONEYLINE&oddsFormat=Decimal&periodNumber=0";


        private const string StraightBetsUrl = "https://api.pinnacle.com/v2/bets/straight";

        public SportsModel GetSports()
        {
            var url = string.Format(SportsUrl);
            var uri = new Uri(url);

            return WebGet<SportsModel>(uri);
        }

        public LeaguesModel GetLeaguesForSport(int sportId)
        {
            var url = string.Format(LeaguesUrl, sportId);
            var uri = new Uri(url);

            return WebGet<LeaguesModel>(uri);
        }

        public OddsModel GetOddsForSport(int sportId)
        {
            var url = string.Format(OddsSportUrl, sportId);
            var uri = new Uri(url);

            return WebGet<OddsModel>(uri);
        }

        public OddsModel GetOddsForEvent(int sportId, int eventId)
        {
            var url = string.Format(OddsEventUrl, sportId, eventId);
            var uri = new Uri(url);

            return WebGet<OddsModel>(uri);
        }

        public FixturesModel GetFixturesForSportLeague(int sportId, int leagueId)
        {
            string url;
            if (leagueId == 0)
            {
                url = string.Format(FixturesUrl, sportId);
            }
            else
            {
                url = string.Format(FixturesByLeaguesUrl, sportId, leagueId);
            }

            var uri = new Uri(url);
            return WebGet<FixturesModel>(uri);
        }

        public LineModel GetLineForEvent(int sportId, int leagueId, int eventId)
        {
            var url = string.Format(LinesUrl, sportId, leagueId, eventId);
            var uri = new Uri(url);

            return WebGet<LineModel>(uri);
        }
    }
}