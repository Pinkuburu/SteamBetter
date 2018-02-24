namespace ConsoleSteam.Models
{
    /// <summary>
    /// "https://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1?key={0}",
    /// </summary>
    public class LiveLeagueGamesModel
    {

            public Result result { get; set; }

        public class Result
        {
            public Game[] games { get; set; }
            public int status { get; set; }
        }

        public class Game
        {
            public Player2[] players { get; set; }
            public Radiant_Team radiant_team { get; set; }
            public Dire_Team dire_team { get; set; }
            public long lobby_id { get; set; }
            public long match_id { get; set; }
            public int spectators { get; set; }
            public int series_id { get; set; }
            public int game_number { get; set; }
            public int league_id { get; set; }
            public int stream_delay_s { get; set; }
            public int radiant_series_wins { get; set; }
            public int dire_series_wins { get; set; }
            public int series_type { get; set; }
            public int league_series_id { get; set; }
            public int league_game_id { get; set; }
            public string stage_name { get; set; }
            public int league_tier { get; set; }
            public Scoreboard scoreboard { get; set; }
        }

        public class Radiant_Team
        {
            public string team_name { get; set; }
            public int team_id { get; set; }
            public ulong team_logo { get; set; }
            public bool complete { get; set; }
        }

        public class Dire_Team
        {
            public string team_name { get; set; }
            public int team_id { get; set; }
            public ulong team_logo { get; set; }
            public bool complete { get; set; }
        }

        public class Scoreboard
        {
            public float duration { get; set; }
            public int roshan_respawn_timer { get; set; }
            public Radiant radiant { get; set; }
            public Dire dire { get; set; }
        }

        public class Radiant
        {
            public int score { get; set; }
            public int tower_state { get; set; }
            public int barracks_state { get; set; }
            public Player[] players { get; set; }
            public Ability[] abilities { get; set; }
            public Pick[] picks { get; set; }
            public Ban[] bans { get; set; }
        }

        public class Player
        {
            public int player_slot { get; set; }
            public int account_id { get; set; }
            public int hero_id { get; set; }
            public int kills { get; set; }
            public int death { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int gold { get; set; }
            public int level { get; set; }
            public int gold_per_min { get; set; }
            public int xp_per_min { get; set; }
            public int ultimate_state { get; set; }
            public int ultimate_cooldown { get; set; }
            public int item0 { get; set; }
            public int item1 { get; set; }
            public int item2 { get; set; }
            public int item3 { get; set; }
            public int item4 { get; set; }
            public int item5 { get; set; }
            public int respawn_timer { get; set; }
            public float position_x { get; set; }
            public float position_y { get; set; }
            public int net_worth { get; set; }
        }

        public class Ability
        {
            public int ability_id { get; set; }
            public int ability_level { get; set; }
        }

        public class Pick
        {
            public int hero_id { get; set; }
        }

        public class Ban
        {
            public int hero_id { get; set; }
        }

        public class Dire
        {
            public int score { get; set; }
            public int tower_state { get; set; }
            public int barracks_state { get; set; }
            public Player1[] players { get; set; }
            public Ability1[] abilities { get; set; }
            public Pick1[] picks { get; set; }
            public Ban1[] bans { get; set; }
        }

        public class Player1
        {
            public int player_slot { get; set; }
            public int account_id { get; set; }
            public int hero_id { get; set; }
            public int kills { get; set; }
            public int death { get; set; }
            public int assists { get; set; }
            public int last_hits { get; set; }
            public int denies { get; set; }
            public int gold { get; set; }
            public int level { get; set; }
            public int gold_per_min { get; set; }
            public int xp_per_min { get; set; }
            public int ultimate_state { get; set; }
            public int ultimate_cooldown { get; set; }
            public int item0 { get; set; }
            public int item1 { get; set; }
            public int item2 { get; set; }
            public int item3 { get; set; }
            public int item4 { get; set; }
            public int item5 { get; set; }
            public int respawn_timer { get; set; }
            public float position_x { get; set; }
            public float position_y { get; set; }
            public int net_worth { get; set; }
        }

        public class Ability1
        {
            public int ability_id { get; set; }
            public int ability_level { get; set; }
        }

        public class Pick1
        {
            public int hero_id { get; set; }
        }

        public class Ban1
        {
            public int hero_id { get; set; }
        }

        public class Player2
        {
            public int account_id { get; set; }
            public string name { get; set; }
            public int hero_id { get; set; }
            public int team { get; set; }
        }

    }
}