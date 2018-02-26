using System;

namespace PinnacleApiClient.Models
{
    public class LineModel
    {
            public string status { get; set; }
            public float price { get; set; }
            public int lineId { get; set; }
            public object altLineId { get; set; }
            public object team1Score { get; set; }
            public object team2Score { get; set; }
            public object team1RedCards { get; set; }
            public object team2RedCards { get; set; }
            public float maxRiskStake { get; set; }
            public float minRiskStake { get; set; }
            public float maxWinStake { get; set; }
            public float minWinStake { get; set; }
            public DateTime effectiveAsOf { get; set; }

    }
}