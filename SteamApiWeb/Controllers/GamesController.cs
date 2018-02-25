using System.Web.Mvc;
using SteamApiClient.Interfaces;
using SteamApiClient.Services;

namespace SteamBetterWeb.Controllers
{
    public class GamesController : Controller
    {
        public ActionResult Leagues()
        {

            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/key.user"));
            ISteampoweredApi steam = new SteampoweredApi(key);
            var listing = steam.Dota2MatchApi.GetLeagueListing();

            return View(listing);
        }

        public ActionResult LeagueGames()
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/key.user"));
            ISteampoweredApi steam = new SteampoweredApi(key);
            var games = steam.Dota2MatchApi.GetLiveLeagueGames();

            return View(games);
        }
    }
}