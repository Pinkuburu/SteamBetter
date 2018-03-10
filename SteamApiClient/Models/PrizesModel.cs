// ReSharper disable InconsistentNaming

namespace SteamApiClient.Models
{
    public class PrizesModel
    {

        public Results result { get; set; }
        

        public class Results
        {
            public int prize_pool { get; set; }
            public int league_id { get; set; }
            public int status { get; set; }
        }


    }
}