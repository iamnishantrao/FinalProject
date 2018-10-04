using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubDashboard.Models
{
    public class UserRepos
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int StarredRepositoriesId { get; set; }
        public StarredRepositories StarredRepositories { get; set; }
    }
}
