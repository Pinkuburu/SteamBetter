namespace SteamBetterWeb.ViewModels.Twitch
{
    public class TopGamesViewModel
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
            public string Name { get; set; }
            public string BoxArtUrl { get; set; }
        }
    }
}