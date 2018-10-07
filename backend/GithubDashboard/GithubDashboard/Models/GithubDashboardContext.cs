using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using GithubDashboard.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GithubDashboard.Models
{
    public class GithubDashboardContext : IdentityDbContext<IdentityUser>
    {
        public GithubDashboardContext(DbContextOptions<GithubDashboardContext> options)
            : base(options)
        {

        }

        //public DbSet<Profile> Profiles { get; set; }
        //public DbSet<Issue> Issues { get; set; }
        //public DbSet<Pull> Pulls { get; set; }
        //public DbSet<Repos> Repos { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<StarredRepositories> StarredRepositories { get; set; }
        public DbSet<UserRepos> UserRepos { get; set; }

        
        //making primary key and foreign key
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Composite key
            modelBuilder.Entity<UserRepos>()
                .HasKey(o => new { o.StarredRepositoriesId, o.UserId });

 

            //Foreign key with User Table
            modelBuilder.Entity<UserRepos>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserRepos)
                .HasForeignKey(bc => bc.UserId);

            //Foreign key with StarredRepositories Table
            modelBuilder.Entity<UserRepos>()
                .HasOne(bc => bc.StarredRepositories)
                .WithMany(c => c.UserRepos)
                .HasForeignKey(bc => bc.StarredRepositoriesId);
        }

    }
}
