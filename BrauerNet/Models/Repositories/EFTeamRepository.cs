using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFTeamRepository
    {
        BrauerNetDbContext db;

        public EFGroupRepository(BrauerNetDbContext connection = null)
        {
            if (connection == null)
            {
                this.db = new BrauerNetDbContext();
            }
            else
            {
                this.db = connection;
            }
        }

        public IQueryable<Team> Teams
        { get { return db.Teams; } }

        public Team Save(Team team)
        {
            db.Teams.Add(team);
            db.SaveChanges();
            return team;
        }

        public Team Edit(Team team)
        {
            db.Entry(team).State = EntityState.Modified;
            db.SaveChanges();
            return team;
        }

        public void Remove(Team team)
        {
            db.Team.Remove(team);
            db.SaveChanges();
        }
    }
}
