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
    public class StarredRepoesController : ControllerBase
    {
        private readonly GithubDashboardContext _context;

        public StarredRepoesController(GithubDashboardContext context)
        {
            _context = context;
        }

        // GET: api/StarredRepoes
        [HttpGet]
        public IEnumerable<StarredRepo> GetStarredRepo()
        {
            return _context.StarredRepo;
        }

        // GET: api/StarredRepoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStarredRepo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //var starredRepo = await _context.StarredRepo.FindAsync(id);
            var starredRepo = _context.StarredRepo.Where(d => d.userId == id).ToList();

            if (starredRepo == null)
            {
                return NotFound();
            }

            return Ok(starredRepo);
        }

        // PUT: api/StarredRepoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStarredRepo([FromRoute] int id, [FromBody] StarredRepo starredRepo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != starredRepo.StarredRepoId)
            {
                return BadRequest();
            }

            _context.Entry(starredRepo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StarredRepoExists(id))
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

        // POST: api/StarredRepoes
        [HttpPost]
        public async Task<IActionResult> PostStarredRepo([FromBody] StarredRepo starredRepo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StarredRepo.Add(starredRepo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStarredRepo", new { id = starredRepo.StarredRepoId }, starredRepo);
        }

        // DELETE: api/StarredRepoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStarredRepo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var starredRepo = await _context.StarredRepo.FindAsync(id);
            if (starredRepo == null)
            {
                return NotFound();
            }

            _context.StarredRepo.Remove(starredRepo);
            await _context.SaveChangesAsync();

            return Ok(starredRepo);
        }

        private bool StarredRepoExists(int id)
        {
            return _context.StarredRepo.Any(e => e.StarredRepoId == id);
        }
    }
}