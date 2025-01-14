﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace EmmaSharper
{
    /// <summary>
    /// Used to add new members or update existing members in bulk.
    /// </summary>
    public class MemberBulk
    {
        /// <summary>
        /// Email address of member to add or update
        /// </summary>
        [JsonProperty("email")]
        public string MemberEmail { get; set; }

        /// <summary>
        /// Names and values of user-defined fields to update
        /// </summary>
        [JsonProperty("fields")]
        public Dictionary<string, object> Fields { get; set; }
    }
}
