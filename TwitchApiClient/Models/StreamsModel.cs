// ReSharper disable InconsistentNaming

using System;

namespace TwitchApiClient.Models
{
    public class StreamsModel
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
            public string user_id { get; set; }
            public string game_id { get; set; }
            public string[] community_ids { get; set; }
            public string type { get; set; }
            public string title { get; set; }
            public int viewer_count { get; set; }
            public DateTime started_at { get; set; }
            public string language { get; set; }
            public string thumbnail_url { get; set; }
        }

    }
}