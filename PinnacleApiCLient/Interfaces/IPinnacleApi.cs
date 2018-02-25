using PinnacleApiClient.Models;

namespace PinnacleApiClient.Interfaces
{
    public interface IPinnacleApi
    {
        SportsModel GetSports();
        LeaguesModel GetLeaguesForSport(int sportId);
        OddsModel GetOddsForSports(int sportId);

    }
}