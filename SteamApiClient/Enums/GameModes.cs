namespace SteamApiClient.Enums
{
    public static class GameModes
    {
        public static string Describe(int id)
        {
            switch (id)
            {

                case 0: return "None";
                case 1: return "All Pick";
                case 2: return "Captain's Mode";
                case 3: return "Random Draft";
                case 4: return "Single Draft";
                case 5: return "All Random";
                case 6: return "Intro";
                case 7: return "Diretide";
                case 8: return "Reverse Captain's Mode";
                case 9: return "The Greeviling";
                case 10: return "Tutorial";
                case 11: return "Mid Only";
                case 12: return "Least Played";
                case 13: return "New Player Pool";
                case 14: return "Compendium Matchmaking";
                case 16: return "Captain's Draft";
                case 18: return "Ability Draft";
                case 20: return "All Random Deathmatch";
                case 21: return "1v1 Mid Only";
                case 22: return "Ranked Matchmaking";

                default: return "Invalid";
            }
        }
    }
}