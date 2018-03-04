
using System;

namespace SteamBetterWeb.ViewModels.Twitch
{
    public class StreamsViewModel
    {
        public Datum[] Data { get; set; }
        public Paginate Pagination { get; set; }

        public class Paginate
        {
            public string Cursor { get; set; }
        }

        public class Datum
        {
            public string Id { get; set; }
            public string UserId { get; set; }
            public string GameId { get; set; }
            public string[] CommunityIds { get; set; }
            public string Type { get; set; }
            public string Title { get; set; }
            public int ViewerCount { get; set; }
            public DateTime StartedAt { get; set; }
            public string Language { get; set; }
            public string ThumbnailUrl { get; set; }
        }
    }
}