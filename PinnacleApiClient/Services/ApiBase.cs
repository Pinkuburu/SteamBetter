﻿using System;
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

        protected T WebGet<T>(Uri uri, string fileName = "")
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add(HttpRequestHeader.Authorization, $"Basic {_token}");

                try
                {
                    string data = wc.DownloadString(uri);

                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        SaveJsonFileAsync(fileName, data);
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

        private void SaveJsonFileAsync(string fileName, string data)
        {
            Task.Factory.StartNew(() => SaveJsonFile(fileName, data));
        }

        private void SaveJsonFile(string fileName, string data)
        {
            try
            {
                using (var stream = File.CreateText($"..\\..\\PinnacleSampleResponses\\{fileName}.json"))
                {
                    stream.Write(data);
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}