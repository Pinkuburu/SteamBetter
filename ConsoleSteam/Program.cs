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

        private static void Main(string[] args)
        {
            string key = File.ReadAllText("key.user");

            string[] urls = new[]
            {

                "http://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1/?key={0}",
                "http://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1/?format=json&key={0}",
                "http://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1/?format=vdf&key={0}",
                "http://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1/?format=XML&key={0}",

            };

            //GET
            // https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?format=XML&key=<key>
            // https://api.steampowered.com/IDOTA2Match_570/GetMatchHistory/V001/?start_at_match_id=27110133&key=<key>

            int i = 0;
            foreach (var urlf in urls)
            {
                string data;
                string url = string.Format(urlf, key);

                Uri uri = new Uri(url);


                using (WebClient wc = new WebClient())
                {
                    data = wc.DownloadString(uri);
                    Console.WriteLine(data);
                }

                using (var stream = File.CreateText($"..\\..\\SampleResponses\\r{i}.json"))
                {
                    stream.Write(data);
                    stream.Close();
                }

                i++;
            }



            /*
            var gm = JsonConvert.DeserializeObject<LeagueGamesModel>(data);

            foreach (var game in gm.result.games)
            {
                Console.WriteLine($"{game.dire_team?.team_name} vs {game.radiant_team?.team_name}");
            }
            */
            Console.Read();

        }


    }

}
