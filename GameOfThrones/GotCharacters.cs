using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GameOfThrones
{
    public class GotCharacters
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("titles")]
        public IList<string> Titles { get; set; }

        [JsonProperty("children")]
        public IList<string> Children { get; set; }

        [JsonProperty("allegiance")]
        public IList<string> Allegiance { get; set; }
        
        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("house")]
        public string House { get; set; }

        [JsonProperty("alive")]
        public bool Alive { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("birth")]
        public int? Birth { get; set; }

        [JsonProperty("placeOfBirth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("death")]
        public int? Death { get; set; }

        [JsonProperty("placeOfDeath")]
        public string PlaceOfDeath { get; set; }
        
        [JsonProperty("father")]
        public string Father { get; set; }

        [JsonProperty("mother")]
        public string Mother { get; set; }

        [JsonProperty("heir")]
        public string Heir { get; set; }
    }
}
