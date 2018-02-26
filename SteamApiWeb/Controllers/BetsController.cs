using System.Configuration;
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

        public ActionResult Leagues(int sportId)
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var games = pinnacle.GetLeaguesForSport(sportId);

            return View(games);
        }

        public ActionResult Fixtures(int sportId, int leagueId)
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var fixtures = pinnacle.GetFixturesForSportLeague(sportId, leagueId);

            return View(fixtures);
        }

        public ActionResult Odds(int sportId, int eventId)
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var games = pinnacle.GetOddsForEvent(sportId, eventId);

            if (games != null)
            {
                return View(games);
            }
            else
            {
                return View("NoData");
            }
        }

        public ActionResult LineById(int lineId)
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            //var lines = pinnacle.GetLinesForEvent(sportId, leagueId, eventId);

            return View("Line");
        }
        
        public ActionResult Line(int sportId, int leagueId, int eventId)
        {
            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            var lines = pinnacle.GetLinesForEvent(sportId, leagueId, eventId);

            return View(lines);
        }

        [HttpPost]
        public ActionResult PostBet(int lineid)
        {
            throw new System.NotImplementedException();
        }
    }
}