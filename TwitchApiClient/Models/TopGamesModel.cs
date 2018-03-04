// ReSharper disable InconsistentNaming

namespace TwitchApiClient.Models
{
    public class TopGamesModel
    {
        public Datum[] data { get; set; }
        public Pagination pagination { get; set; }

        public class Pagination
        {
            public string cursor { get; set; }
        }

        public class Datum
        {
            public string id { get; set; }
            public string name { get; set; }
            public string box_art_url { get; set; }
        }

    }
}