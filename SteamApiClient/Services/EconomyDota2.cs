using System;
using System.Runtime.Caching;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;

namespace SteamApiClient.Services
{
    public class EconomyDota2Match : ApiBase, IEconDota2
    {
        private const string GameItemsUrl = "http://api.steampowered.com/IEconDOTA2_570/GetGameItems/v1?key={0}";
        private const string HeroesUrl = "http://api.steampowered.com/IEconDOTA2_570/GetHeroes/v1?key={0}";
        private const string RaritiesUrl = "http://api.steampowered.com/IEconDOTA2_570/GetRarities/v1?key={0}";

        private readonly string _key;

        private static MemoryCache _itemsCache = MemoryCache.Default;
        private static MemoryCache _heroesCache = MemoryCache.Default;
        private static MemoryCache _raritiesCache = MemoryCache.Default;

        public EconomyDota2Match(string key)
        {
            _key = key;
        }

        public GameItemsModel GetGameItems()
        {
            const string cacheKey = "GameItems";
            if (!_itemsCache.Contains(cacheKey))
            {
                var url = string.Format(GameItemsUrl, _key);
                var uri = new Uri(url);
                var data = WebGet<GameItemsModel>(uri);
                _itemsCache.Set(cacheKey, data, DateTimeOffset.Now.AddHours(1));
                return data;
            }
            else
            {
                var data = _itemsCache.Get(cacheKey) as GameItemsModel;
                return data;
            }
        }

        public HeroesModel GetHeroes()
        {
            const string cacheKey = "Heroes";
            if (!_heroesCache.Contains(cacheKey))
            {
                var url = string.Format(HeroesUrl, _key);
                var uri = new Uri(url);
                var data = WebGet<HeroesModel>(uri);
                _heroesCache.Set(cacheKey, data, DateTimeOffset.Now.AddHours(1));
                return data;
            }
            else
            {
                var data = _heroesCache.Get(cacheKey) as HeroesModel;
                return data;
            }
        }

        public RaritiesModel GetRarities()
        {
            const string cacheKey = "Rarities";
            if (!_raritiesCache.Contains(cacheKey))
            {
                var url = string.Format(RaritiesUrl, _key);
                var uri = new Uri(url);
                var data = WebGet<RaritiesModel>(uri);
                _raritiesCache.Set(cacheKey, data, DateTimeOffset.Now.AddHours(1));
                return data;
            }
            else
            {
                var data = _raritiesCache.Get(cacheKey) as RaritiesModel;
                return data;
            }
        }
    }

}