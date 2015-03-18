﻿using RestSharp.Deserializers;
using System;
using System.Collections.Generic;

namespace EmmaSharp.Models.Response
{
    public class ResponseClicks
    {
        [DeserializeAs(Name = "link_id")]
        public int LinkId { get; set; }

        [DeserializeAs(Name = "fields")]
        public Dictionary<string, string> Fields { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public DateTime? Timestamp { get; set; }

        [DeserializeAs(Name = "member_id")]
        public int MemberId { get; set; }

        [DeserializeAs(Name = "member_since")]
        public DateTime? MemberSince { get; set; }

        [DeserializeAs(Name = "email_domain")]
        public string EmailDomain { get; set; }

        [DeserializeAs(Name = "email_user")]
        public string EmailUser { get; set; }

        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        [DeserializeAs(Name = "member_status_id")]
        public int MemberStatusId { get; set; }
    }
}