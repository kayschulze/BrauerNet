using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFGroupRepository : IGroupRepository
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

        public IQueryable<Group> Groups
        { get { return db.Groups; } }

        public Group Save(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();
            return group;
        }

        public Group Edit(Group group)
        {
            db.Entry(group).State = EntityState.Modified;
            db.SaveChanges();
            return group;
        }

        public void Remove(Group group)
        {
            db.Groups.Remove(group);
            db.SaveChanges();
        }
    }
}
