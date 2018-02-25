using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PinnacleApiClient.Services
{
    public abstract class ApiBase
    {
        public ApiBase(string token)
        {
            _token = token;
        }

        private readonly string _token;

        protected T WebGet<T>(Uri uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add(HttpRequestHeader.Authorization, $"Basic {_token}");

                try
                {
                    string data = wc.DownloadString(uri);

                    var lm = JsonConvert.DeserializeObject<T>(data);
                    return lm;
                }
                catch (WebException wex)
                {
                    var resp = new StreamReader(wex.Response.GetResponseStream()).ReadToEnd();

                    Console.WriteLine(resp);
                    throw new Exception(resp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw new Exception(ex.Message);
                }
            }
        }

    }
}