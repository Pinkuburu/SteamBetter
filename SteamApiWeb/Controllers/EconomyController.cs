using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;
using SteamApiClient.Services;
using SteamBetterWeb.Mappings;
using SteamBetterWeb.ViewModels.Economy;
using SteamBetterWeb.ViewModels.Games;

namespace SteamBetterWeb.Controllers
{
    public class EconomyController : Controller
    {
        public EconomyController()
        {
            _mapper = AutoMapperConfig.CreateGamesMapper();
        }

        private string _key;
        private readonly IMapper _mapper;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _key = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/steam_key.user"));
        }

        public ActionResult Heroes()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var heroes = steam.EconomyDota2Api.GetHeroes();

            HeroesViewModel heroVms = _mapper.Map<HeroesViewModel>(heroes);

            return View(heroVms);
        }

        public ActionResult GameItems()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var items = steam.EconomyDota2Api.GetGameItems();

            GameItemsViewModel itemVms = _mapper.Map<GameItemsViewModel>(items);

            return View(itemVms);
        }

        public ActionResult Rarities()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var rarities = steam.EconomyDota2Api.GetRarities();
            
            RaritiesViewModel rarityVms = _mapper.Map<RaritiesViewModel>(rarities);

            return View(rarityVms);
        }

    }
}