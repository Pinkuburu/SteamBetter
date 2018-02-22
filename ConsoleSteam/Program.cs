using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleSteam
{
    public class Program
    {

        private static void Main(string[] args)
        {
            string key = File.ReadAllText("key.user");


            string urlFormat1 = "http://api.steampowered.com/IDOTA2Match_570/GetLeagueListing/v1/?key={0}";
            string urlFormat = "http://api.steampowered.com/IDOTA2Match_570/GetLiveLeagueGames/v1/?key={0}";
            //GET
            string data;

            string url = string.Format(urlFormat, key);

            Uri uri = new Uri(url);


            using (WebClient wc = new WebClient())
            {
                data = wc.DownloadString(uri);
                Console.WriteLine(data);
                //                return resp;
                //UInt64 i = 13677626478891679440;

            }



            var gm = JsonConvert.DeserializeObject<LeagueGamesModel>(data);

            foreach (var game in gm.result.games)
            {
                Console.WriteLine($"{game.dire_team?.team_name} vs {game.radiant_team?.team_name}");
            }

            Console.Read();

        }

       
    }

}
