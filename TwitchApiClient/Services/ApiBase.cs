using System;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace TwitchApiClient.Services
{
    public abstract class ApiBase
    {

        protected T WebGet<T>(Uri uri, string clientId)
        {
            using (var wc = new WebClient())
            {
                try
                {
                    if (clientId != "")
                    {
                        wc.Headers.Add("Client-ID", clientId);
                    }

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

        protected T WebPost<T>(Uri uri)
        {
            using (var wc = new WebClient())
            {
                try
                {
                    string data = wc.UploadString(uri, HttpMethod.Post.ToString(), "");

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