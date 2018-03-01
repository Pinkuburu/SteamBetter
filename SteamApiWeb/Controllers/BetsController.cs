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

        private  string _token;
        private readonly IMapper _mapper;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _token = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/token.user"));
        }

        public ActionResult Sports()
        {
            IPinnacleApi pinnacle = new PinnacleApi(_token);
            SportsModel sports = pinnacle.GetSports();

            SportsViewModel sportVms = _mapper.Map<SportsViewModel>(sports);

            return View(sportVms);
        }

        public ActionResult Leagues(int sportId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_token);
            LeaguesModel leagues = pinnacle.GetLeaguesForSport(sportId);

            LeaguesViewModel leagueVms = _mapper.Map<LeaguesViewModel>(leagues);
            leagueVms.SportId = sportId;

            return View(leagueVms);
        }

        public ActionResult Fixtures(int sportId, int leagueId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_token);
            FixturesModel fixtures = pinnacle.GetFixturesForSportLeague(sportId, leagueId);

            FixturesViewModel fixturesVms = _mapper.Map<FixturesViewModel>(fixtures);

            if (fixturesVms != null)
            {
                return View(fixturesVms);
            }
            else
            {
                return View("NoData");
            }
        }

        public ActionResult Odds(int sportId, int eventId)
        {
            IPinnacleApi pinnacle = new PinnacleApi(_token);
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
            IPinnacleApi pinnacle = new PinnacleApi(_token);
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