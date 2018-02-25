using System.Web.Mvc;
using PinnacleApiClient.Interfaces;
using PinnacleApiClient.Services;

namespace SteamBetterWeb.Controllers
{
    public class BetsController : Controller
    {

        public ActionResult Sports()
        {

            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var listing = pinnacle.GetSports();

            return View(listing);
        }

        public ActionResult Leagues()
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var games = pinnacle.GetLeagues();

            return View(games);
        }
    }
}