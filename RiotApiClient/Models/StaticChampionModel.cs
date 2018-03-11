// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Linq;

namespace RiotApiClient.Models
{
    public class StaticChampionModel
    {
        public Data data { get; set; }
        public string type { get; set; }
        public string version { get; set; }


        public class Data
        {
            public IList<BaseChampion> Champions { get; set; }
        }

        public class BaseChampion
        {
            public int id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string title { get; set; }
        }

    }
}