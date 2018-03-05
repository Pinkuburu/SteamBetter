using NUnit.Framework;
using SteamApiClient.Services;

namespace SteamApiClient.Tests.API
{
    [TestFixture]
    public class EconomyDota2Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            _key = System.IO.File.ReadAllText(@"G:\Projects\GitHub\SteamBetter\SteamApiWeb\key.user");

        }

        private string _key;

        [Test]
        public void TestGetHeroes()
        {
            var economyDota2Api = new EconomyDota2Match(_key);

            var h = economyDota2Api.GetHeroes();
            Assert.IsNotNull(h);
        }

        [Test]
        public void TestGetGameItems()
        {
            var economyDota2Api = new EconomyDota2Match(_key);

            var i = economyDota2Api.GetGameItems();
            Assert.IsNotNull(i);

        }

        [Test]
        public void TestGetRarities()
        {
            var economyDota2Api = new EconomyDota2Match(_key);

            var r = economyDota2Api.GetRarities();
            Assert.IsNotNull(r);

        }
    }
}
