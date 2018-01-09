using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BrauerNet.Models;

namespace BrauerNet.Migrations
{
    [DbContext(typeof(BrauerNetDbContext))]
    partial class BrauerNetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3");

            modelBuilder.Entity("BrauerNet.Models.Goal", b =>
                {
                    b.Property<int>("GoalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("GoalId");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("BrauerNet.Models.GoalProject", b =>
                {
                    b.Property<int>("GoalId");

                    b.Property<int>("ProjectId");

                    b.HasKey("GoalId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("GoalProject");
                });

            modelBuilder.Entity("BrauerNet.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BrauerNet.Models.Participant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<int?>("GroupId");

                    b.Property<int?>("GroupId1");

                    b.Property<int?>("GroupId2");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int>("ParticipantId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int?>("TeamId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("GroupId1");

                    b.HasIndex("GroupId2");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("TeamId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BrauerNet.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ParticipantId");

                    b.HasKey("ProjectId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectStakeholder", b =>
                {
                    b.Property<int>("StakeholderId");

                    b.Property<int>("ProjectId");

                    b.HasKey("StakeholderId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectStakeholder");
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectStandard", b =>
                {
                    b.Property<int>("StandardId");

                    b.Property<int>("ProjectId");

                    b.HasKey("StandardId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectStandard");
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectTeam", b =>
                {
                    b.Property<int>("TeamId");

                    b.Property<int>("ProjectId");

                    b.HasKey("TeamId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectTeam");
                });

            modelBuilder.Entity("BrauerNet.Models.Stakeholder", b =>
                {
                    b.Property<int>("StakeholderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Role");

                    b.HasKey("StakeholderId");

                    b.ToTable("Stakeholders");
                });

            modelBuilder.Entity("BrauerNet.Models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Identifier");

                    b.Property<string>("Type");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("BrauerNet.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BrauerNet.Models.GoalProject", b =>
                {
                    b.HasOne("BrauerNet.Models.Goal", "Goal")
                        .WithMany("GoalProjects")
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrauerNet.Models.Project", "Project")
                        .WithMany("GoalProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrauerNet.Models.Participant", b =>
                {
                    b.HasOne("BrauerNet.Models.Group")
                        .WithMany("Mentors")
                        .HasForeignKey("GroupId");

                    b.HasOne("BrauerNet.Models.Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId1");

                    b.HasOne("BrauerNet.Models.Group")
                        .WithMany("Teachers")
                        .HasForeignKey("GroupId2");

                    b.HasOne("BrauerNet.Models.Team")
                        .WithMany("Members")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("BrauerNet.Models.Project", b =>
                {
                    b.HasOne("BrauerNet.Models.Participant")
                        .WithMany("Projects")
                        .HasForeignKey("ParticipantId");
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectStakeholder", b =>
                {
                    b.HasOne("BrauerNet.Models.Project", "Project")
                        .WithMany("ProjectStakeholders")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrauerNet.Models.Stakeholder", "Stakeholder")
                        .WithMany("ProjectStakeholders")
                        .HasForeignKey("StakeholderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectStandard", b =>
                {
                    b.HasOne("BrauerNet.Models.Project", "Project")
                        .WithMany("ProjectStandards")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrauerNet.Models.Standard", "Standard")
                        .WithMany("ProjectStandards")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BrauerNet.Models.ProjectTeam", b =>
                {
                    b.HasOne("BrauerNet.Models.Project", "Project")
                        .WithMany("ProjectTeams")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrauerNet.Models.Team", "Team")
                        .WithMany("ProjectTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BrauerNet.Models.Participant")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BrauerNet.Models.Participant")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BrauerNet.Models.Participant")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
