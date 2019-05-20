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
        public void GetPeople()
        {
            string json = "";
            WebClient client = new WebClient();
            using (Stream stream = client.OpenRead(_url))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        json += line;
                    }
                }
            }

            _people = JsonConvert.DeserializeObject<List<Person>>(json);
        }
    }
}
