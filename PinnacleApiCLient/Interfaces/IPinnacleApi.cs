using PinnacleApiClient.Models;

namespace PinnacleApiClient.Interfaces
{
    public interface IPinnacleApi
    {
        SportsModel GetSports();
        LeaguesModel GetLeagues();
    }
}