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
            public float MaxMoneyline { get; set; }
            public Moneyline Moneyline { get; set; }
            public float MaxSpread { get; set; }
            public float MaxTotal { get; set; }
            public Spread[] Spreads { get; set; }
            public Total[] Totals { get; set; }
        }

        public class Moneyline
        {
            public float Home { get; set; }
            public float Away { get; set; }
        }

        public class Spread
        {
            public float Hdp { get; set; }
            public float Home { get; set; }
            public float Away { get; set; }
            public long AltLineId { get; set; }
        }

        public class Total
        {
            public float Points { get; set; }
            public float Over { get; set; }
            public float Under { get; set; }
            public long AltLineId { get; set; }
        }

    }
}