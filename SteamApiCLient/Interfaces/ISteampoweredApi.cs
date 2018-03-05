
namespace SteamApiClient.Interfaces
{
    public interface ISteampoweredApi
    {
        IDota2Match Dota2MatchApi { get; }
        IEconDota2 EconomyDota2Api { get; }
    }
}