// ReSharper disable InconsistentNaming

namespace RiotApiClient.Models
{
    public class SummonerModel
    {
        public int id { get; set; }
        public int accountId { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public int summonerLevel { get; set; }

    }
}