﻿// <auto-generated />
using System;
using GithubDashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GithubDashboard.Migrations
{
    [DbContext(typeof(GithubDashboardContext))]
    partial class GithubDashboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GithubDashboard.Models.StarredRepo", b =>
                {
                    b.Property<int>("StarredRepoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("clone_url");

                    b.Property<DateTime>("created_at");

                    b.Property<string>("description");

                    b.Property<string>("html_url");

                    b.Property<string>("name");

                    b.Property<DateTime>("pushed_at");

                    b.Property<int>("repo_id");

                    b.Property<DateTime>("updated_at");

                    b.Property<int>("userId");

                    b.Property<string>("user_html_url");

                    b.Property<string>("user_login");

                    b.HasKey("StarredRepoId");

                    b.HasIndex("userId");

                    b.ToTable("StarredRepo");
                });

            modelBuilder.Entity("GithubDashboard.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GithubDashboard.Models.StarredRepo", b =>
                {
                    b.HasOne("GithubDashboard.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
