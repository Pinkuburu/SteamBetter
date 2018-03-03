using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SteamApiClient.Services;

namespace SteamApiClient.Tests.API
{
    [TestFixture]
    public class GameDota2Tests
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

        }

    }
}
