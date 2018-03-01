// ReSharper disable InconsistentNaming

namespace ConsolePinnacle.Models
{
    public class BalanceModel
    {
        public float availableBalance { get; set; }
        public float outstandingTransactions { get; set; }
        public float givenCredit { get; set; }
        public string currency { get; set; }
    }
}