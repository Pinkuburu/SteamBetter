// ReSharper disable InconsistentNaming

using System;

namespace PinnacleApiClient.Models
{
    public class LineModel
    {
        public string status { get; set; }
        public double price { get; set; }
        public int lineId { get; set; }
        public int? altLineId { get; set; }
        public int? team1Score { get; set; }
        public int? team2Score { get; set; }
        public int? team1RedCards { get; set; }
        public int? team2RedCards { get; set; }
        public double maxRiskStake { get; set; }
        public double minRiskStake { get; set; }
        public double maxWinStake { get; set; }
        public double minWinStake { get; set; }
        public DateTime effectiveAsOf { get; set; }

    }
}