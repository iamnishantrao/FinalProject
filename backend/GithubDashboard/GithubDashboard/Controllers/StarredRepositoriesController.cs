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
        public StarredRepositories starredRepositories { get; set; }
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
            _context.StarredRepositories.Add(repo.starredRepositories);
            UserRepos userRepos = new UserRepos();
            userRepos.UserId = repo.User_id;
            userRepos.StarredRepositoriesId = repo.starredRepositories.StarredRepositoriesId;
            _context.UserRepos.Add(userRepos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStarredRepositories", 1);
        }
    }
}