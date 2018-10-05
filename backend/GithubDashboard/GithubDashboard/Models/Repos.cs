using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubDashboard.Models
{
    [ModelBinder(BinderType = typeof(RepoBinder))]
    [JsonConverter(typeof(JsonPathConverter))]
    public class Repos
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("html_url")]
        public string html_url { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("created_at")]
        public DateTime created_at { get; set; }
        [JsonProperty("updated_at")]
        public DateTime updated_at { get; set; }
        [JsonProperty("pushed_at")]
        public DateTime pushed_at { get; set; }
        [JsonProperty("clone_url")]
        public string clone_url { get; set; }
        [JsonProperty("owner.login")]
        public string user_login { get; set; }
        [JsonProperty("owner.html_url")]
        public string user_html_url { get; set; }
    }
}
