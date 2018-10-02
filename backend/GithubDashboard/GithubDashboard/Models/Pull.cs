using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubDashboard.Models
{
    [ModelBinder(BinderType = typeof(PullBinder))]
    [JsonConverter(typeof(JsonPathConverter))]
    public class Pull
    {
        [JsonProperty("id")]
        public int id { get; set; }
        
        [JsonProperty("html_url")]
        public string html_url { get; set; }

        [JsonProperty("number")]
        public int number { get; set; }

        [JsonProperty("state")]
        public string state { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("user.login")]
        public string user_login { get; set; }

        [JsonProperty("body")]
        public string body { get; set; }

        [JsonProperty("created_at")]
        public DateTime created_at { get; set; }

        [JsonProperty("updated_at")]
        public DateTime updated_at { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? closed_at { get; set; }
    }
}
