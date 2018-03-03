// ReSharper disable InconsistentNaming

using System;

namespace PinnacleApiClient.Models
{
    public class OddsModel
    {
        public int sportId { get; set; }
        public int last { get; set; }
        public League[] leagues { get; set; }

        public class League
        {
            public int id { get; set; }
            public Event[] events { get; set; }
        }

        public class Event
        {
            public int id { get; set; }
            public Period[] periods { get; set; }
        }

        public class Period
        {
            public int lineId { get; set; }
            public int number { get; set; }
            public DateTime cutoff { get; set; }
            public double maxMoneyline { get; set; }
            public Moneyline moneyline { get; set; }
            public double maxSpread { get; set; }
            public double maxTotal { get; set; }
            public Spread[] spreads { get; set; }
            public Total[] totals { get; set; }
        }

        public class Moneyline
        {
            public double home { get; set; }
            public double away { get; set; }
        }

        public class Spread
        {
            public double hdp { get; set; }
            public double home { get; set; }
            public double away { get; set; }
            public long altLineId { get; set; }
        }

        public class Total
        {
            public double points { get; set; }
            public double over { get; set; }
            public double under { get; set; }
            public double altLineId { get; set; }
        }

    }
}