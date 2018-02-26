using PinnacleApiClient.Models;

namespace PinnacleApiClient.Interfaces
{
    public interface IPinnacleApi
    {
        SportsModel GetSports();
        LeaguesModel GetLeaguesForSport(int sportId);
        OddsModel GetOddsForSport(int sportId);
        OddsModel GetOddsForEvent(int sportId, int eventId);

        FixturesModel GetFixturesForSportLeague(int sportId, int leagueId);
        LineModel GetLineForEvent(int sportId, int leagueId, int eventId);
    }
}