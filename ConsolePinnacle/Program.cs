using System;
using System.IO;
using System.Net;
using ConsolePinnacle.Models;
using Newtonsoft.Json;

namespace ConsolePinnacle
{
    public class Program
    {
        private static void Main()
        {
            var token = File.ReadAllText("key.user");


            string url1 = "https://api.pinnacle.com/v1/client/balance";
            var url2 = "https://api.pinnacle.com/v2/sports";
            var url32 = "https://api.pinnacle.com/v2/leagues?sportId=12";
            var url = "https://api.pinnacle.com/v1/odds?sportId=12";
            var place = "https://api.pinnacle.com/v2/bets/straight";

            string data;

            Uri uri = new Uri(url);
            int i=0;

            using (WebClient wc = new WebClient())
            {
               // wc.Headers.Add("Content-Type", "application/json");
                wc.Headers.Add(HttpRequestHeader.Authorization, $"Basic {token}");

                Console.WriteLine($"Getting {url}");
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

                var lm = JsonConvert.DeserializeObject<OddsModel>(data);
                foreach (var league in lm.leagues)
                {
                 //   if (league.name.Contains("Dota 2") && league.name.Contains("ESL"))
                 //   {
                    foreach (var eve in league.events)
                    {
                        foreach (var p in eve.periods)
                        {
                            Console.WriteLine($"{league.id} {p.lineId}");
                        }
                    }
                 //   }

                }

                //Console.WriteLine(data);
            }

            using (var stream = File.CreateText($"..\\..\\SampleResponses\\r{i:00}.json"))
            {
                stream.Write(data);
                stream.Close();
            }

            i++;
        
            Console.ReadLine();
        }
    }
}
