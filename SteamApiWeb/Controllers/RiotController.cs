using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using RiotApiClient.Interfaces;
using RiotApiClient.Services;
using SteamBetterWeb.Mappings;
using SteamBetterWeb.ViewModels.Riot;

namespace SteamBetterWeb.Controllers
{
    public class RiotController : Controller
    {
        public RiotController()
        {
            _mapper = AutoMapperConfig.CreateRiotMapper();
        }

        private string _apikey;
        private readonly IMapper _mapper;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _apikey = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/riot_apikey.user"));
        }

        public ActionResult Summoner(string name)
        {
            name = "RiotSchmick";
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var summoner = riot.GetSummoner(name);

            SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(summonerVm);
        }

        public ActionResult FeaturedGames()
        {
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var games = riot.GetFeaturedGames();

           // SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(games);
        }

        public ActionResult Champions()
        {
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var champions = riot.GetChampions();

          //  SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(champions);
        }

        public ActionResult ShardStatus()
        {
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var chards = riot.GetShardStatus();

            // SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(chards);
        }

        public ActionResult StaticChampions()
        {
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var champions = riot.GetStaticChampions();

            // SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(champions);
        }

    }
}