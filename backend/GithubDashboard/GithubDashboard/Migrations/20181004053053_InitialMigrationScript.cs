using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GithubDashboard.Migrations
{
    public partial class InitialMigrationScript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StarredRepositories",
                columns: table => new
                {
                    StarredRepositoriesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Repo_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    pushed_at = table.Column<DateTime>(nullable: false),
                    clone_url = table.Column<string>(nullable: true),
                    user_login = table.Column<string>(nullable: true),
                    user_html_url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarredRepositories", x => x.StarredRepositoriesId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRepos",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    StarredRepositoriesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRepos", x => new { x.StarredRepositoriesId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRepos_StarredRepositories_StarredRepositoriesId",
                        column: x => x.StarredRepositoriesId,
                        principalTable: "StarredRepositories",
                        principalColumn: "StarredRepositoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRepos_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRepos_UserId",
                table: "UserRepos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRepos");

            migrationBuilder.DropTable(
                name: "StarredRepositories");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
