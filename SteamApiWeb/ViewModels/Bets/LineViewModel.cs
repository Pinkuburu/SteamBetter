using System;

namespace SteamBetterWeb.ViewModels.Bets
{
    public class LineViewModel
    {
            public string Status { get; set; }
            public float Price { get; set; }
            public int LineId { get; set; }
            public object AltLineId { get; set; }
            public object Team1Score { get; set; }
            public object Team2Score { get; set; }
            public object Team1RedCards { get; set; }
            public object Team2RedCards { get; set; }
            public float MaxRiskStake { get; set; }
            public float MinRiskStake { get; set; }
            public float MaxWinStake { get; set; }
            public float MinWinStake { get; set; }
            public DateTime EffectiveAsOf { get; set; }

    }
}