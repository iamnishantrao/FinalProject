using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GithubDashboard.Models
{
    [ModelBinder(BinderType = typeof(IssueBinder))]
    [JsonConverter(typeof(JsonPathConverter))]
    public class Issue
    {       
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("number")]
        public int number { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("user.login")]
        public string user_login { get; set; }

        [JsonProperty("state")]
        public string state { get; set; }

        [JsonProperty("assignee.login")]
        public string assignee { get; set; }

        [JsonProperty("created_at")]
        public DateTime created_at { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? closed_at { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }
    }
}
