namespace SteamBetterWeb.ViewModels.Bets
{
    public class BalanceViewModel
    {
        public double AvailableBalance { get; set; }
        public double OutstandingTransactions { get; set; }
        public double GivenCredit { get; set; }
        public string Currency { get; set; }
    }
}