using SteamApiClient.Models;

namespace SteamApiClient.Interfaces
{
    public interface IDota2Match
    {
        LeagueListingModel GetLeagueListing();
        LiveLeagueGamesModel GetLiveLeagueGames();
        MatchDetailsModel GetMatchDetails(long matchId);
        MatchHistoryModel GetMatchHistory();


        TeamInfoModel GetTeamInfo(long teamId);
        PlayerStatsModel GetPlayerStats(long accountId);
        ScheduleModel GetSchedule(int leagueId);
    }
}