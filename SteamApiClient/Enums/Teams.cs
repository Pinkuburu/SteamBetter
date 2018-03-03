namespace SteamApiClient.Enums
{
    public static class Teams
    {
        public static string Describe(int id)
        {
            switch (id)
            {
                case 0: return "Radiant";
                case 1: return "Dire";
                case 2: return "Broadcaster";
                case 4: return "Unassigned";

                default: return "Invalid";

            }
        }
    }
}