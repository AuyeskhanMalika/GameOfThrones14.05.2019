using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;

namespace GameOfThrones
{
    public class GetDataService
    {
        public static List<GotCharacters> GetListOfGotCharacters()
        {
            return JsonConvert.DeserializeObject<List<GotCharacters>>(Downloader.DataJsonFormat(ConfigurationManager.AppSettings["urlString"]));
        }
    }
}
