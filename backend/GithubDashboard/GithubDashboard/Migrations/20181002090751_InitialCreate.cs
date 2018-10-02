using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GithubDashboard.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    number = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    user_login = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    assignee = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    closed_at = table.Column<DateTime>(nullable: true),
                    body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    login = table.Column<string>(nullable: true),
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    avatar_url = table.Column<string>(nullable: true),
                    html_url = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    company = table.Column<string>(nullable: true),
                    blog = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    bio = table.Column<string>(nullable: true),
                    followers = table.Column<int>(nullable: false),
                    following = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pulls",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    html_url = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false),
                    state = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    user_login = table.Column<string>(nullable: true),
                    body = table.Column<string>(nullable: true),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    closed_at = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pulls", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Pulls");
        }
    }
}
