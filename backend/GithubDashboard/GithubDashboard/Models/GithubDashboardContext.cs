using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using GithubDashboard.Models;

namespace GithubDashboard.Models
{
    public class GithubDashboardContext: DbContext
    {
        public GithubDashboardContext(DbContextOptions<GithubDashboardContext> options)
            : base(options)
        {

        }

        //public DbSet<Profile> Profiles { get; set; }
        //public DbSet<Issue> Issues { get; set; }
        //public DbSet<Pull> Pulls { get; set; }
        //public DbSet<Repo> Repos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<StarredRepo> StarredRepo { get; set; }
    }
}
