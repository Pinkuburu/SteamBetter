using NUnit.Framework;
using RiotApiClient.Services;

namespace RiotApiClient.Tests.API
{
    [TestFixture]
    public class RiotApiTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            _apiKey = System.IO.File.ReadAllText(@"G:\Projects\GitHub\SteamBetter\SteamApiWeb\apikey.user");

        }

        private string _apiKey;

        [Test]
        public void TestSummoner()
        {
            var riotApi = new RiotGamesApi(_apiKey);
            var summoner = riotApi.GetSummoner("RiotSchmick");

            Assert.IsNotNull(summoner);
        }

        [Test]
        public void TestChamions()
        {
            var riotApi = new RiotGamesApi(_apiKey);
          //   var summoner = riotApi.GetSummoner("RiotSchmick");
            
            var champ = riotApi.GetChamions();
            Assert.IsNotNull(champ);
        }

        [Test]
        public void TestFeaturedGames()
        {
            var riotApi = new RiotGamesApi(_apiKey);
            //
            var games = riotApi.GetFeaturedGames();
            Assert.IsNotNull(games);
        }
        
        [Test]
        public void TestShardStatus()
        {
            var riotApi = new RiotGamesApi(_apiKey);
            //
            var games = riotApi.GetShardStatus();
            Assert.IsNotNull(games);
        }
    }
}
