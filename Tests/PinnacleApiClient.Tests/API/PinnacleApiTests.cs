using NUnit.Framework;

namespace PinnacleApiClient.Tests.API
{
    [TestFixture]
    public class PinnacleApiTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            _token = System.IO.File.ReadAllText(@"G:\Projects\GitHub\SteamBetter\SteamApiWeb\pinnacle_token.user");

        }

        private string _token;

        [Test]
        public void TestLines()
        {

        }
    }
}
