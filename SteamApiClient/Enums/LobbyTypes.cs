namespace SteamApiClient.Enums
{
    public static class LobbyTypes
    {
        public static string Describe(int id)
        {
            switch (id)
            {

                case 0: return "Public matchmaking";
                case 1: return "Practise";
                case 2: return "Tournament";
                case 3: return "Tutorial";
                case 4: return "Co-op with bots";
                case 5: return "Team match";
                case 6: return "Solo Queue";
                case 7: return "Ranked Matchmaking";
                case 8: return "1v1 Solo Mid";

                default: return "Invalid";
            }
        }
    }
}