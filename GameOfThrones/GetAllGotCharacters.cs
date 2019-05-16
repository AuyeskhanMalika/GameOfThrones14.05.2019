using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GameOfThrones
{
    public class GetAllGotCharacters
    {
        public static class Downloader
        {
            public static string DataJsonFormat(string url)
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        return client.DownloadString(url);
                    }
                    catch (WebException exception)
                    {
                        return exception.Message;
                    }
                }
            }
        }
    }
}
