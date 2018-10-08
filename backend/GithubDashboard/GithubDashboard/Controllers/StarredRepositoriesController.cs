using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GithubDashboard.Models;

namespace GithubDashboard.Controllers
{

    public class RepoBinder
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
        public int User_id { get; set; }
    }
    [Route("api/starredrepos")]
    [ApiController]
    public class StarredRepositoriesController : ControllerBase
    {
        private readonly GithubDashboardContext _context;

        public StarredRepositoriesController(GithubDashboardContext context)
        {
            _context = context;
        }

        // GET: api/StarredRepositories
        [HttpGet]
        public IEnumerable<StarredRepositories> GetStarredRepositories()
        {
            return _context.StarredRepositories;
        }

        // GET: api/StarredRepositories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStarredRepositories([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var starredRepositories = await _context.StarredRepositories.FindAsync(id);

            if (starredRepositories == null)
            {
                return NotFound();
            }

            return Ok(starredRepositories);
        }

        // POST: api/StarredRepositories
        [HttpPost]
        public async Task<IActionResult> PostStarredRepositories([FromBody] RepoBinder repo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            StarredRepositories starredRepositories = new StarredRepositories();
            starredRepositories.Repo_id = repo.Repo_id;
            starredRepositories.name = repo.name;
            starredRepositories.html_url = repo.html_url;
            starredRepositories.description = repo.description;
            starredRepositories.created_at = repo.created_at;
            starredRepositories.updated_at = repo.updated_at;
            starredRepositories.pushed_at = repo.pushed_at;
            starredRepositories.clone_url = repo.clone_url;
            starredRepositories.user_login = repo.user_login;
            starredRepositories.user_html_url = repo.user_html_url;
            _context.StarredRepositories.Add(starredRepositories);

            UserRepos userRepos = new UserRepos();
            userRepos.UserId = 1;
            userRepos.StarredRepositoriesId = starredRepositories.StarredRepositoriesId;
            await _context.UserRepos.AddAsync(userRepos);
            await _context.SaveChangesAsync();

            return Ok(1);
        }
    }
}