using SteamApiClient.Models;

namespace SteamApiClient.Interfaces
{
    public interface IDota2Match
    {
        LeagueListingModel GetLeagueListing();
        LiveLeagueGamesModel GetLiveLeagueGames(int leagueId);
        MatchDetailsModel GetMatchDetails(long matchId);
        MatchHistoryModel GetMatchHistory();


    }
}