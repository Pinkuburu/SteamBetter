using System;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;

namespace SteamApiClient.Services
{
    public class SteampoweredApi : ISteampoweredApi
    {
        public SteampoweredApi(string key)
        {
            Dota2MatchApi  = new Dota2Match(key);
            EconomyDota2Api = new EconomyDota2Match(key);
        }

        public IDota2Match Dota2MatchApi { get; }
        public IEconDota2 EconomyDota2Api { get; }
    }
}