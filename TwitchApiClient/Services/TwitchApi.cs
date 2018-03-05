using System;
using TwitchApiClient.Interfaces;
using TwitchApiClient.Models;

namespace TwitchApiClient.Services
{
    public class TwitchApi: ApiBase, ITwitchApi
    {
        public TwitchApi(string secret)
        {
            _secret = secret;
        }

        private const string LoginUrl = "https://id.twitch.tv/oauth2/token?client_id={0}&client_secret={1}&grant_type=client_credentials";
        private const string TopGamesUrl = "https://api.twitch.tv/helix/games/top";
        private const string StreamsUrl = "https://api.twitch.tv/helix/streams?game_id={0}";

        private readonly string _secret;

        private TokenModel Login(string clientId, string secret)
        {
            var url = string.Format(LoginUrl, clientId, secret);
            var uri = new Uri(url);

            return WebPost<TokenModel>(uri);
        }

        public TopGamesModel GetTopGames(string clientId)
        {
            var url = string.Format(TopGamesUrl);
            var uri = new Uri(url);

            return WebGet<TopGamesModel>(uri, clientId);
        }

        public StreamsModel GetStreams(string clientId, int gameId)
        {
            var url = string.Format(StreamsUrl, gameId);
            var uri = new Uri(url);

            return WebGet<StreamsModel>(uri, clientId);
        }
    }
}
