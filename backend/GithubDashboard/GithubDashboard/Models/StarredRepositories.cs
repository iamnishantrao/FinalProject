using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GithubDashboard.Models
{
    public class StarredRepositories
    {
        public int StarredRepositoriesId { get; set; }
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

        [ForeignKey("UserRefId")]
        public virtual User User { get; set; }
    }
}
