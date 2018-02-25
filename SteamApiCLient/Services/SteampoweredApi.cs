using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;

namespace SteamApiClient.Services
{
    public class SteampoweredApi : ISteampoweredApi
    {
        public SteampoweredApi(string key)
        {
 //           string key = File.ReadAllText(HttpContext.Current.Server.MapPath("~/key.user");

            Dota2MatchApi  = new Dota2Match(key);

        }

        public IDota2Match Dota2MatchApi { get; } 

        public class Dota2Match : ApiBase, IDota2Match
        {
            private readonly string _leagueListingUrl = "https://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1?key={0}";

            private string _liveLeagueGamesUrl = "https://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1?key={0}";
            private string _matchDetailsUrl = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/v1?key={0}&match_id=3750525726";
            private string _matchHistoryUrl = "https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/v1?key={0}";
            private string _teamInfoUrl = "https://api.steampowered.com/IDOTA2Match_570/GetTeamInfoByTeamID/v1?key={0}";
            private string _playerStatsUrl = "https://api.steampowered.com/IDOTA2Match_570/GetTournamentPlayerStats/v1?key={0}&account_id=292917068";

            private readonly string _key;

            public Dota2Match(string key)
            {
                _key = key;
            }

            public LeagueListingModel GetLeagueListing()
            {
                var url = string.Format(_leagueListingUrl, _key);
                var uri = new Uri(url);

                return WebGet<LeagueListingModel>(uri, nameof(_leagueListingUrl));
            }

            public LiveLeagueGamesModel GetLiveLeagueGames()
            {
                var url = string.Format(_liveLeagueGamesUrl, _key);
                var uri = new Uri(url);

                return WebGet<LiveLeagueGamesModel>(uri, nameof(_liveLeagueGamesUrl));
            }

        }
    }
}