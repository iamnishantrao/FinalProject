using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GithubDashboard.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace GithubDashboard.Controllers
{

    public class SearchUserBinder
    {
        public int total_count { get; set; }
        public IEnumerable<Profile> items { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class SearchProfilesController : ControllerBase
    {
        private readonly GithubDashboardContext _context;

        public SearchProfilesController(GithubDashboardContext context)
        {
            _context = context;
        }

        // GET: api/SearchProfiles
        [HttpGet("{id}")]
        public SearchUserBinder GetProfile([FromRoute] string id)
        {
            string url = "https://api.github.com/search/users?q="+id;
            var json = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "DhruvPandey";
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                json = reader.ReadToEnd();
            }
            SearchUserBinder profiles = JsonConvert.DeserializeObject<SearchUserBinder>(json);
            return profiles;
        }

        
    }
}