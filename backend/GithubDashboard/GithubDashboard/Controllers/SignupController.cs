using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GithubDashboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GithubDashboard.Controllers
{
   
    public class RegistrationViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private readonly GithubDashboardContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public SignupController(UserManager<IdentityUser> userManager, GithubDashboardContext appDbContext)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = new IdentityUser { UserName = model.UserName, Email = model.Email};

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(result);

            await _appDbContext.User.AddAsync(new User { IdentityId = userIdentity.Id,Password = model.Password, Email = model.Email,UserName = model.UserName });
            await _appDbContext.SaveChangesAsync();

            return new OkObjectResult(result);
        }
    }
}