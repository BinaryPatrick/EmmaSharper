﻿using Newtonsoft.Json;

namespace EmmaSharper
{
    public class GroupName
    {
        [JsonProperty("group_name")]
        public string Name { get; set; }
    }
}