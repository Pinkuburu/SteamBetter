namespace SteamBetterWeb.ViewModels.Bets
{
    public class BalanceViewModel
    {
        public float AvailableBalance { get; set; }
        public float OutstandingTransactions { get; set; }
        public float GivenCredit { get; set; }
        public string Currency { get; set; }
    }
}