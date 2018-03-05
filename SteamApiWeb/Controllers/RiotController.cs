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

            _apikey = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/apikey.user"));
        }

        public ActionResult Summoner()
        {
            IRiotGamesApi riot = new RiotGamesApi(_apikey);
            var summoner = riot.GetSummoner("RiotSchmick");

            SummonerViewModel summonerVm = _mapper.Map<SummonerViewModel>(summoner);

            return View(summonerVm);
        }

    }
}