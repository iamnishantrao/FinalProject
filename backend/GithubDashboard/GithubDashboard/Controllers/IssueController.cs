using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using GithubDashboard.Models;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace GithubDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        [HttpGet("{id}")]
        public IEnumerable<Issue> Get([FromRoute]string id)
        {
            var str = id.Split(" ");

            string url = "https://api.github.com/repos/" + str[0] + "/" + str[1] + "/issues";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Nisant Yadav";
            request.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Console.WriteLine(response.StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string json = reader.ReadToEnd();
            Console.WriteLine(json);
            IEnumerable<Issue> issues = JsonConvert.DeserializeObject<IEnumerable<Issue>>(json);

            return issues;
        }
    }
}