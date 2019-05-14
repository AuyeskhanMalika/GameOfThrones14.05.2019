using Newtonsoft.Json;

namespace GameOfThrones
{
    public class Pagerank
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }
}