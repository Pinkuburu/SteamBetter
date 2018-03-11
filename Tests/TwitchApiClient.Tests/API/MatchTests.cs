using NUnit.Framework;

namespace TwitchApiClient.Tests.API
{
    [TestFixture]
    public class MatchTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            _secret = System.IO.File.ReadAllText(@"G:\Projects\GitHub\SteamBetter\SteamApiWeb\twitch_secret.user");

        }

        private string _secret;

        [Test]
        public void TestMatch()
        {

        }
    }
}
