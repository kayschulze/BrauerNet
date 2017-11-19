using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class BrauerNetDbContext : IdentityDbContext<Participant>
    {
        public BrauerNetDbContext()
        {

        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Stakeholder> Stakeholders { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=3306;database=brauernetdb;uid=root;pwd=root;");
        }

        public BrauerNetDbContext(DbContextOptions<BrauerNetDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GoalProject>()
                .HasKey(p => new { p.GoalId, p.ProjectId });

            modelBuilder.Entity<GoalProject>()
                .HasOne(gp => gp.Goal)
                .WithMany(g => g.GoalProjects)
                .HasForeignKey(gp => gp.GoalId);

            modelBuilder.Entity<GoalProject>()
                .HasOne(gp => gp.Project)
                .WithMany(p => p.GoalProjects)
                .HasForeignKey(gp => gp.ProjectId);

            modelBuilder.Entity<ProjectStakeholder>()
                .HasKey(p => new { p.StakeholderId, p.ProjectId });

            modelBuilder.Entity<ProjectStakeholder>()
                .HasOne(ps => ps.Stakeholder)
                .WithMany(s => s.ProjectStakeholders)
                .HasForeignKey(ps => ps.StakeholderId);

            modelBuilder.Entity<ProjectStakeholder>()
                .HasOne(ps => ps.Project)
                .WithMany(p => p.ProjectStakeholders)
                .HasForeignKey(ps => ps.ProjectId);

            modelBuilder.Entity<ProjectStandard>()
                .HasKey(p => new { p.StandardId, p.ProjectId });

            modelBuilder.Entity<ProjectStandard>()
                .HasOne(ps => ps.Standard)
                .WithMany(s => s.ProjectStandards)
                .HasForeignKey(ps => ps.StandardId);

            modelBuilder.Entity<ProjectStandard>()
                .HasOne(ps => ps.Project)
                .WithMany(p => p.ProjectStandards)
                .HasForeignKey(ps => ps.ProjectId);

            modelBuilder.Entity<ProjectTask>()
                .HasKey(p => new { p.TaskId, p.ProjectId });

            modelBuilder.Entity<ProjectTask>()
                .HasOne(pt => pt.Task)
                .WithMany(t => t.ProjectTasks)
                .HasForeignKey(pt => pt.TaskId);

            modelBuilder.Entity<ProjectTask>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.ProjectTasks)
                .HasForeignKey(pt => pt.ProjectId);

            modelBuilder.Entity<ProjectTeam>()
                .HasKey(p => new { p.TeamId, p.ProjectId });

            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pt => pt.Team)
                .WithMany(t => t.ProjectTeams)
                .HasForeignKey(pt => pt.TeamId);

            modelBuilder.Entity<ProjectTeam>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.ProjectTeams)
                .HasForeignKey(pt => pt.ProjectId);
        }
    }
}
