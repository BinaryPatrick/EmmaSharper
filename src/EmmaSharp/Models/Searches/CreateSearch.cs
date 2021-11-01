﻿using EmmaSharp.Internals;
using Newtonsoft.Json;

namespace EmmaSharp
{
    public class CreateSearch
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("criteria")]
        [JsonConverter(typeof(RawStringJsonConverter))]
        public string Criteria { get; set; }
    }
}