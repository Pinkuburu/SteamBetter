namespace SteamBetterWeb.ViewModels.Bets
{
    public class BalanceViewModel
    {
        public float availableBalance { get; set; }
        public float outstandingTransactions { get; set; }
        public float givenCredit { get; set; }
        public string currency { get; set; }
    }
}