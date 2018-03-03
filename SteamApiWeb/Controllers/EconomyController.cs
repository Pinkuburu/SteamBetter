using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using SteamApiClient.Interfaces;
using SteamApiClient.Models;
using SteamApiClient.Services;
using SteamBetterWeb.Mappings;
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

            _key = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/key.user"));
        }

        public ActionResult Heroes()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var games = steam.EconomyDota2Api.GetHeroes();

            LiveLeagueGamesViewModel gameVms = _mapper.Map<LiveLeagueGamesViewModel>(games);

            return View(gameVms);
        }

        public ActionResult GameItems()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var match = steam.EconomyDota2Api.GetGameItems();

            return View(match);
        }

        public ActionResult Rarities()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var match = steam.EconomyDota2Api.GetRarities();

            return View(match);
        }

    }
}