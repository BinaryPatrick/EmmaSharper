﻿using Newtonsoft.Json;

namespace EmmaSharp
{
    public class MembersAdd
    {
        [JsonProperty("import_id")]
        public long ImportId { get; set; }
    }
}