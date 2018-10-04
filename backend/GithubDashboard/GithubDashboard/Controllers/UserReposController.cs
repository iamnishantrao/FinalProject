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
    [Route("api/[controller]")]
    [ApiController]
    public class UserReposController : ControllerBase
    {
        private readonly GithubDashboardContext _context;

        public UserReposController(GithubDashboardContext context)
        {
            _context = context;
        }

        // GET: api/UserRepos
        [HttpGet]
        public IEnumerable<UserRepos> GetUserRepos()
        {
            return _context.UserRepos;
        }

        // GET: api/UserRepos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRepos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRepos = await _context.UserRepos.FindAsync(id);

            if (userRepos == null)
            {
                return NotFound();
            }

            return Ok(userRepos);
        }

        // PUT: api/UserRepos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserRepos([FromRoute] int id, [FromBody] UserRepos userRepos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userRepos.StarredRepositoriesId)
            {
                return BadRequest();
            }

            _context.Entry(userRepos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserReposExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserRepos
        [HttpPost]
        public async Task<IActionResult> PostUserRepos([FromBody] UserRepos userRepos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.UserRepos.Add(userRepos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UserReposExists(userRepos.StarredRepositoriesId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUserRepos", new { id = userRepos.StarredRepositoriesId }, userRepos);
        }

        // DELETE: api/UserRepos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRepos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRepos = await _context.UserRepos.FindAsync(id);
            if (userRepos == null)
            {
                return NotFound();
            }

            _context.UserRepos.Remove(userRepos);
            await _context.SaveChangesAsync();

            return Ok(userRepos);
        }

        private bool UserReposExists(int id)
        {
            return _context.UserRepos.Any(e => e.StarredRepositoriesId == id);
        }
    }
}