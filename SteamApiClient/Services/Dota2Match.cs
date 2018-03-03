using System;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;

namespace SteamApiClient.Services
{
    public class Dota2Match : ApiBase, IDota2Match
    {
        private const string LeagueListingUrl = "https://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1?key={0}";

        private const string LiveLeagueGamesUrl = "https://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1?key={0}";
        private const string MatchDetailsUrl = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/v1?key={0}&match_id={1}";

        private const string MatchHistoryUrl = "https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/v1?key={0}";
        private const string TeamInfoUrl = "https://api.steampowered.com/IDOTA2Match_570/GetTeamInfoByTeamID/v1?key={0}&start_at_team_id={1}&teams_requested=1";
        private const string PlayerStatsUrl = "https://api.steampowered.com/IDOTA2Match_570/GetTournamentPlayerStats/v1?key={0}&account_id={1}";

        private readonly string _key;

        public Dota2Match(string key)
        {
            _key = key;
        }

        public LeagueListingModel GetLeagueListing()
        {
            var url = string.Format(LeagueListingUrl, _key);
            var uri = new Uri(url);

            return WebGet<LeagueListingModel>(uri);
        }

        public LiveLeagueGamesModel GetLiveLeagueGames()
        {
            var url = string.Format(LiveLeagueGamesUrl, _key);
            var uri = new Uri(url);

            return WebGet<LiveLeagueGamesModel>(uri);
        }

        public MatchDetailsModel GetMatchDetails(long matchId)
        {
            var url = string.Format(MatchDetailsUrl, _key, matchId);
            var uri = new Uri(url);

            return WebGet<MatchDetailsModel>(uri);
        }

        public MatchHistoryModel GetMatchHistory()
        {
            var url = string.Format(MatchHistoryUrl, _key);
            var uri = new Uri(url);

            return WebGet<MatchHistoryModel>(uri);
        }

        public TeamInfoModel GetTeamInfo(long teamId)
        {
            var url = string.Format(TeamInfoUrl, _key, teamId);
            var uri = new Uri(url);

            return WebGet<TeamInfoModel>(uri);
        }

        public PlayerStatsModel GetPlayerStats(long accountId)
        {
            var url = string.Format(PlayerStatsUrl, _key, accountId);
            var uri = new Uri(url);

            return WebGet<PlayerStatsModel>(uri);
        }
    }
}