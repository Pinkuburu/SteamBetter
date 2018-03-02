using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using SteamApiClient.Interfaces;
using SteamApiClient.Services;

namespace SteamBetterWeb.Controllers
{
    public class GamesController : Controller
    {
        public GamesController()
        {
            _mapper = AutoMapperConfig.CreateMapper();
        }

        private  string _key;
        private readonly IMapper _mapper;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _key = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/key.user"));
        }

        public ActionResult Leagues()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var listing = steam.Dota2MatchApi.GetLeagueListing();

            return View(listing);
        }

        public ActionResult Games(int leagueId)
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var games = steam.Dota2MatchApi.GetLiveLeagueGames(leagueId);

            return View(games);
        }

        public ActionResult MatchHistory()
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var match = steam.Dota2MatchApi.GetMatchHistory();

            return View(match);
        }

        public ActionResult MatchDetails(long matchId)
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var match = steam.Dota2MatchApi.GetMatchDetails(matchId);

            return View(match);
        }

        public ActionResult TeamInfo(long teamId)
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var team = steam.Dota2MatchApi.GetTeamInfo(teamId);

            return View(team);
        }

        public ActionResult PlayerStats(int accountId)
        {
            ISteampoweredApi steam = new SteampoweredApi(_key);
            var team = steam.Dota2MatchApi.GetPlayerStats(accountId);

            return View(team);
            
        }
    }
}