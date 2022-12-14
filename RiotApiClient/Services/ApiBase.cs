using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RiotApiClient.Services
{
    public class ApiBase
    {
        protected T WebGet<T>(Uri uri)
        {
            using (var wc = new WebClient())
            {

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

        protected JObject WebGetDynamic(Uri uri)
        {
            using (var wc = new WebClient())
            {
                try
                {
                    string data = wc.DownloadString(uri);

                    var lm = JObject.Parse(data);
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
