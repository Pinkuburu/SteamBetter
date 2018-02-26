using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using PinnacleApiClient.Interfaces;
using PinnacleApiClient.Models;
using PinnacleApiClient.Services;
using SteamBetterWeb.ViewModels.Bets;

namespace SteamBetterWeb.Controllers
{
    public class BetsController : Controller
    {
        public BetsController()
        {
            _mapper = AutoMapperConfig.CreateMapper();
        }

        private  string _key;
        private readonly IMapper _mapper;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _key = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/token.user"));

        }

        public ActionResult Sports()
        {

            string key = System.IO.File.ReadAllText(HttpContext.Server.MapPath("~/token.user"));
            IPinnacleApi pinnacle = new PinnacleApi(key);
            SportsModel sports = pinnacle.GetSports();

            SportsViewModel sportVms = _mapper.Map<SportsViewModel>(sports);

            return View(sportVms);
        }

        public ActionResult Leagues(int sportId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_key);
            LeaguesModel leagues = pinnacle.GetLeaguesForSport(sportId);

            LeaguesViewModel leagueVms = _mapper.Map<LeaguesViewModel>(leagues);
            leagueVms.sportId = sportId;

            return View(leagueVms);
        }

        public ActionResult Fixtures(int sportId, int leagueId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_key);
            FixturesModel fixtures = pinnacle.GetFixturesForSportLeague(sportId, leagueId);

            FixturesViewModel fixturesVms = _mapper.Map<FixturesViewModel>(fixtures);

            return View(fixturesVms);
        }

        public ActionResult Odds(int sportId, int eventId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_key);
            OddsModel odds = pinnacle.GetOddsForEvent(sportId, eventId);

            OddsViewModel oddsVms = _mapper.Map<OddsViewModel>(odds);

            if (oddsVms != null)
            {
                return View(oddsVms);
            }
            else
            {
                return View("NoData");
            }
        }

        
        
        public ActionResult Line(int sportId, int leagueId, int eventId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_key);
            LineModel line = pinnacle.GetLineForEvent(sportId, leagueId, eventId);

            LineViewModel lineVm = _mapper.Map<LineViewModel>(line);

            return View(lineVm);
        }

        [HttpPost]
        public ActionResult PostBet(LineViewModel line)
        {
            return View("Line", line);
        }
    }
}