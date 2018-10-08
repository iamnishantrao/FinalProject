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
    public class SearchRepoModel
    {
        public int Repo_id { get; set; }
        public string name { get; set; }
        public string html_url { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime pushed_at { get; set; }
        public string clone_url { get; set; }
        public string user_login { get; set; }
        public string user_html_url { get; set; }
    }
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
        public IEnumerable<SearchRepoModel> GetRepos([FromRoute] string id)
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
            List<SearchRepoModel> list = new List<SearchRepoModel>();
            foreach (var x in repos.items)
            {
                SearchRepoModel searchRepoModel = new SearchRepoModel();
                searchRepoModel.Repo_id = x.id;
                searchRepoModel.name = x.name;
                searchRepoModel.user_html_url = x.user_html_url;
                searchRepoModel.user_login = x.user_login;
                searchRepoModel.html_url = x.html_url;
                searchRepoModel.description = x.description;
                searchRepoModel.created_at = x.created_at;
                searchRepoModel.pushed_at = x.pushed_at;
                searchRepoModel.updated_at = x.updated_at;
                searchRepoModel.clone_url = x.clone_url;
                list.Add(searchRepoModel);

            }
            IEnumerable<SearchRepoModel> models = list;
            return models;
        }
    }
}