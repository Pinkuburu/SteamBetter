using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ConsoleSteam.Models;
using Newtonsoft.Json;

namespace ConsoleSteam
{
    public class Program
    {
        private static void Main()
        {
            string key = File.ReadAllText("key.user");

            string[] urls = new[]
            {

                "https://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1?key={0}",
                "https://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1?key={0}",
             //   "https://api.steampowered.com/IDOTA2Match_570/GetScheduledLeagueGames/v1?key={0}", // 404
                "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/v1?key={0}&match_id=3750525726",
                "https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/v1?key={0}",
                "https://api.steampowered.com/IDOTA2Match_570/GetTeamInfoByTeamID/v1?key={0}",
                "https://api.steampowered.com/IDOTA2Match_570/GetTournamentPlayerStats/v1?key={0}&account_id=292917068",

                
                "https://api.steampowered.com/IEconDOTA2_570/GetHeroes/v1?key={0}",
                "https://api.steampowered.com/IEconDOTA2_570/GetRarities/v1?key={0}",
                "https://api.steampowered.com/IEconDOTA2_570/GetGameItems/v1?key={0}",

                "https://api.steampowered.com/IDOTA2MatchStats_570/GetRealtimeStats/v1?key={0}&server_steam_id=", // 400 8

              //  "https://api.steampowered.com/IDOTA2AutomatedTourney_570/GetActiveTournamentList/v1?key={0}", // 403

                "https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1?key={0}&appid=570",
                "https://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v1?key={0}&appid=379720&steamid=76561197971874144", // 

                "https://api.steampowered.com/ISteamUser/GetFriendList/v1?key={0}&steamid=76561197971874144&relationship=friend", // 

                "https://api.steampowered.com/IPlayerService/GetSteamLevel/v1?key={0}&steamid=76561197971874144",
                "https://api.steampowered.com/IPlayerService/GetBadges/v1?key={0}&steamid=76561197971874144",

                "https://api.steampowered.com/ISteamApps/GetAppList/v2/",


            };

            //GET
            // https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?format=XML&key=<key>
            // https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?start_at_match_id=27110133&key=<key>

            int i = 0;
            foreach (var urlf in urls)
            {
                if (string.IsNullOrWhiteSpace(urlf))
                {
                    continue;
                }

                string data;
                string url = string.Format(urlf, key);

                Uri uri = new Uri(url);


                using (WebClient wc = new WebClient())
                {
                    Console.WriteLine($"Getting {i} {urlf}");
                    try
                    {
                        data = wc.DownloadString(uri);

                    }
                    catch (WebException wex)
                    {
                        var wr = (HttpWebResponse) wex.Response;
                        
                        var resp = new StreamReader(wr.GetResponseStream()).ReadToEnd();

                        data = resp;
                        Console.WriteLine(data);
                        //throw;
                    }
                    catch (Exception ex)
                    {
                        data = ex.ToString();
                        Console.WriteLine(ex);
                        //throw;
                    }

                    //Console.WriteLine(data);
                }

                using (var stream = File.CreateText($"..\\..\\SampleResponses\\r{i:00}.json"))
                {
                    stream.Write(data);
                    stream.Close();
                }

                i++;
            }

            // 1869482   3661624  5185139


            using (WebClient wc = new WebClient())
            {
                var urlf = "https://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1?key={0}";

                Console.WriteLine($"Getting {i} {urlf}");
                string url = string.Format(urlf, key);
                Uri uri = new Uri(url);

                var data = wc.DownloadString(uri);

                var lm = JsonConvert.DeserializeObject<LeagueListingModel>(data);

                foreach (var league in lm.result.leagues)
                {
                    if (league.name.Contains("ESL"))
                    {
                        Console.WriteLine($"{league.name} {league.description} {league.tournament_url} ({league.leagueid})");
                    }

                }

                Console.Read();

            }

            using (WebClient wc = new WebClient())
            {
                var urlf = "https://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1?key={0}";

                Console.WriteLine($"Getting {i} {urlf}");
                string url = string.Format(urlf, key);
                Uri uri = new Uri(url);

                var data = wc.DownloadString(uri);

                var gm = JsonConvert.DeserializeObject<LiveLeagueGamesModel>(data);

                foreach (var game in gm.result.games)
                {
                    Console.WriteLine($"{game.dire_team?.team_name} ({game.dire_team?.team_id}) vs {game.radiant_team?.team_name} ({game.radiant_team?.team_id})");


                }

                Console.Read();

            }

        }

    }
}
