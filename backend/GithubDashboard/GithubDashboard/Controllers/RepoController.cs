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
    [Route("api/[controller]")]
    [ApiController]
    public class RepoController : ControllerBase
    {
        // GET: api/Repo
        [HttpGet("{id}")]
        public IEnumerable<Repos> Get(string id)
        {
            string url = "https://api.github.com/users/"+id+"/repos";
            var json = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "DhruvPandey";
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            IEnumerable<Repos> repositories = JsonConvert.DeserializeObject<IEnumerable<Repos>>(json);
            return repositories;
        }
    }
}
