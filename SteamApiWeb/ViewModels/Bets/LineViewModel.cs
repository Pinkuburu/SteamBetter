using System;

namespace SteamBetterWeb.ViewModels.Bets
{
    public class LineViewModel
    {
            public string Status { get; set; }
            public double Price { get; set; }
            public int LineId { get; set; }
            public int? AltLineId { get; set; }
            public int? Team1Score { get; set; }
            public int? Team2Score { get; set; }
            public int? Team1RedCards { get; set; }
            public int? Team2RedCards { get; set; }
            public double MaxRiskStake { get; set; }
            public double MinRiskStake { get; set; }
            public double MaxWinStake { get; set; }
            public double MinWinStake { get; set; }
            public DateTime EffectiveAsOf { get; set; }

    }
}