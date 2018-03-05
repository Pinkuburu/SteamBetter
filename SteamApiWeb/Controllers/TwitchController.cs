using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using SteamBetterWeb.Mappings;
using SteamBetterWeb.ViewModels.Twitch;
using TwitchApiClient.Models;
using TwitchApiClient.Services;

namespace SteamBetterWeb.Controllers
{
    public class TwitchController : Controller
    {
        public TwitchController()
        {
            _mapper = AutoMapperConfig.CreateTwitchMapper();
            _clientId = "wfap1eul4xnpw44mqvs9nbltzuffg3";
        }

        private string _key;
        private readonly IMapper _mapper;
        private readonly string _clientId;
      //  private string _token;

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            _key = System.IO.File.ReadAllText(requestContext.HttpContext.Server.MapPath("~/secret.user"));
        }

        public ActionResult TopGames()
        {
            TwitchApi twitch = new TwitchApi(_key);
            TopGamesModel games = twitch.GetTopGames(_clientId);
            TopGamesViewModel gamesVm = _mapper.Map<TopGamesViewModel>(games);

            return View(gamesVm);
        }

        public ActionResult Streams(int gameId)
        {
            TwitchApi twitch = new TwitchApi(_key);
            StreamsModel games = twitch.GetStreams(_clientId, gameId);
            StreamsViewModel gamesVm = _mapper.Map<StreamsViewModel>(games);

            return View(gamesVm);
        }

       /* private void LoginGetToken()
        {
            TwitchApi twitch = new TwitchApi(_key);
            TokenModel token = twitch.Login(_clientId, _key);
            _token = token.access_token;

        }*/
    }
}