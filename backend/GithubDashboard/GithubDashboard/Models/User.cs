﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace GithubDashboard.Models
{
    public class User
    {
        public int UserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public string IdentityId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<UserRepos> UserRepos { get; set; }
    }
}
