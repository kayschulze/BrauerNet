using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFGoalRepository : IGoalRepository
    {
        BrauerNetDbContext db;

        public EFGoalRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Goal> Goals
        { get { return db.Goals; } }

        public Goal Save(Goal goal)
        {
            db.Goals.Add(goal);
            db.SaveChanges();
            return goal;
        }

        public Goal Edit(Goal goal)
        {
            db.Entry(goal).State = EntityState.Modified;
            db.SaveChanges();
            return goal;
        }

        public void Remove(Goal goal)
        {
            db.Goals.Remove(goal);
            db.SaveChanges();
        }
    }
}
