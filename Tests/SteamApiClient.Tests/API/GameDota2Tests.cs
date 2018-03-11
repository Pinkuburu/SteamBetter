using NUnit.Framework;

namespace SteamApiClient.Tests.API
{
    [TestFixture]
    public class GameDota2Tests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            _key = System.IO.File.ReadAllText(@"G:\Projects\GitHub\SteamBetter\SteamApiWeb\steam_key.user");

        }

        private string _key;

        [Test]
        public void TestGetHeroes()
        {

        }

    }
}
