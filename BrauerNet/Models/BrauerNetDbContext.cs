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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
