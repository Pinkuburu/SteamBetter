using System;

namespace SteamBetterWeb.ViewModels.Bets
{
    public class OddsViewModel
    {
        public int SportId { get; set; }
        public int Last { get; set; }
        public League[] Leagues { get; set; }

        public class League
        {
            public int Id { get; set; }
            public Event[] Events { get; set; }
        }

        public class Event
        {
            public int Id { get; set; }
            public Period[] Periods { get; set; }
        }

        public class Period
        {
            public int LineId { get; set; }
            public int Number { get; set; }
            public DateTime Cutoff { get; set; }
            public double MaxMoneyline { get; set; }
            public Moneyline Moneyline { get; set; }
            public double MaxSpread { get; set; }
            public double MaxTotal { get; set; }
            public Spread[] Spreads { get; set; }
            public Total[] Totals { get; set; }
        }

        public class Moneyline
        {
            public double Home { get; set; }
            public double Away { get; set; }
        }

        public class Spread
        {
            public double Hdp { get; set; }
            public double Home { get; set; }
            public double Away { get; set; }
            public long AltLineId { get; set; }
        }

        public class Total
        {
            public double Points { get; set; }
            public double Over { get; set; }
            public double Under { get; set; }
            public long AltLineId { get; set; }
        }

    }
}