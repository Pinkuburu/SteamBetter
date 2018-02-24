using SteamApiClient.Services;

namespace SteamApiClient.Interfaces
{
    public interface ISteampoweredApi
    {
        IDota2Match Dota2MatchApi { get; }
    }
}