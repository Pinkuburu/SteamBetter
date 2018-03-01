namespace SteamApiClient.Enums
{
    public static class Skills
    {
        public static string Describe(int id)
        {
            switch (id)
            {
                case 0: return "Any";
                case 1: return "Normal";
                case 2: return "High";
                case 3: return "Very High";

                default: return "Invalid";

            }
        }
    }
}