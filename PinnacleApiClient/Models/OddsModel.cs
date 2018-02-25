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
            public float maxMoneyline { get; set; }
            public Moneyline moneyline { get; set; }
            public float maxSpread { get; set; }
            public float maxTotal { get; set; }
            public Spread[] spreads { get; set; }
            public Total[] totals { get; set; }
        }

        public class Moneyline
        {
            public float home { get; set; }
            public float away { get; set; }
        }

        public class Spread
        {
            public float hdp { get; set; }
            public float home { get; set; }
            public float away { get; set; }
            public long altLineId { get; set; }
        }

        public class Total
        {
            public float points { get; set; }
            public float over { get; set; }
            public float under { get; set; }
            public long altLineId { get; set; }
        }

    }
}