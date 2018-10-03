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

        //// GET: api/Repo/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Repo
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Repo/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
