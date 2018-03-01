using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SteamApiClient.Models;

namespace SteamApiClient.Services
{
    public abstract class ApiBase
    {

        protected T WebGet<T>(Uri uri)
        {
            using (var wc = new WebClient())
            {
                try
                {
                    string data = wc.DownloadString(uri);

                    var error = JsonConvert.DeserializeObject<ErrorModel>(data);
                    if (error?.result?.error != null)
                    {
                        throw new Exception(error.result.error);
                    }

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