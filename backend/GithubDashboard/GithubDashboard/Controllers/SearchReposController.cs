using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GithubDashboard.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GithubDashboard.Controllers
{
    public class SearchReposBinder
    {
        public int total_count { get; set; }
        public IEnumerable<Repos> items { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class SearchReposController : ControllerBase
    {
        [HttpGet("{id}")]
        public IEnumerable<Repos> GetRepos([FromRoute] string id)
        {
            string url = "https://api.github.com/search/repositories?q=" + id;
            var json = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "DhruvPandey";
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            SearchReposBinder repos = JsonConvert.DeserializeObject<SearchReposBinder>(json);
            return repos.items;
        }
    }
}