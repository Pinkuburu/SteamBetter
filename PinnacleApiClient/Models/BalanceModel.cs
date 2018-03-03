// ReSharper disable InconsistentNaming

namespace PinnacleApiClient.Models
{
    public class BalanceModel
    {
        public double availableBalance { get; set; }
        public double outstandingTransactions { get; set; }
        public double givenCredit { get; set; }
        public string currency { get; set; }
    }
}