
namespace SteamBetterWeb.ViewModels.Games
{
    public class LiveLeagueGamesViewModel
    {
        public Results Result { get; set; }

        public class Results
        {
            public Game[] Games { get; set; }
            public int Status { get; set; }
        }

        public class Game
        {
            public Player2[] Players { get; set; }
            public Radiant_Team RadiantTeam { get; set; }
            public Dire_Team DireTeam { get; set; }
            public long LobbyId { get; set; }
            public long MatchId { get; set; }
            public int Spectators { get; set; }
            public int SeriesId { get; set; }
            public int GameNumber { get; set; }
            public int LeagueId { get; set; }
            public int StreamDelayS { get; set; }
            public int RadiantSeriesWins { get; set; }
            public int DireSeriesWins { get; set; }
            public int SeriesType { get; set; }
            public int LeagueSeriesId { get; set; }
            public int LeagueGameId { get; set; }
            public string StageName { get; set; }
            public int LeagueTier { get; set; }
            public Scoreboard Scoreboard { get; set; }
        }

        public class Radiant_Team
        {
            public string TeamName { get; set; }
            public int TeamId { get; set; }
            public ulong TeamLogo { get; set; }
            public bool Complete { get; set; }
        }

        public class Dire_Team
        {
            public string TeamName { get; set; }
            public int TeamId { get; set; }
            public ulong TeamLogo { get; set; }
            public bool Complete { get; set; }
        }

        public class Scoreboard
        {
            public double duration { get; set; }
            public int roshan_respawn_timer { get; set; }
            public Radiant radiant { get; set; }
            public Dire dire { get; set; }
        }

        public class Radiant
        {
            public int Score { get; set; }
            public int TowerState { get; set; }
            public int BarracksState { get; set; }
            public Player[] Players { get; set; }
            public Ability[] Abilities { get; set; }
            public Pick[] Picks { get; set; }
            public Ban[] Bans { get; set; }
        }

        public class Player
        {
            
            public int PlayerSlot { get; set; }
            public int AccountId { get; set; }
            public int HeroId { get; set; }
            public int Kills { get; set; }
            public int Death { get; set; }
            public int Assists { get; set; }
            public int LastHits { get; set; }
            public int Denies { get; set; }
            public int Gold { get; set; }
            public int Level { get; set; }
            public int GoldPerMin { get; set; }
            public int XpPerMin { get; set; }
            public int UltimateState { get; set; }
            public int UltimateCooldown { get; set; }
            public int Item0 { get; set; }
            public int Item1 { get; set; }
            public int Item2 { get; set; }
            public int Item3 { get; set; }
            public int Item4 { get; set; }
            public int Item5 { get; set; }
            public int RespawnTimer { get; set; }
            public double PositionX { get; set; }
            public double PositionY { get; set; }
            public int NetWorth { get; set; }
        }

        public class Ability
        {
            public int AbilityId { get; set; }
            public int AbilityLevel { get; set; }
        }

        public class Pick
        {
            public int HeroId { get; set; }
        }

        public class Ban
        {
            public int HeroId { get; set; }
        }

        public class Dire
        {
            public int Score { get; set; }
            public int TowerState { get; set; }
            public int BarracksState { get; set; }
            public Player[] Players { get; set; }
            public Ability[] Abilities { get; set; }
            public Pick[] Picks { get; set; }
            public Ban[] Bans { get; set; }
        }


        public class Player2
        {
            public int AccountId { get; set; }
            public string name { get; set; }
            public int HeroId { get; set; }
            public int Team { get; set; }
        }

    }
}