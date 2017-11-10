using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFStandardRepository : IStandardRepository
    {
        BrauerNetDbContext db;

        public EFStandardRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Standard> Standards
        { get { return db.Standards; } }

        public Standard Save(Standard standard)
        {
            db.Standards.Add(standard);
            db.SaveChanges();
            return standard;
        }

        public Standard Edit(Standard standard)
        {
            db.Entry(standard).State = EntityState.Modified;
            db.SaveChanges();
            return standard;
        }

        public void Remove(Standard standard)
        {
            db.Standards.Remove(standard);
            db.SaveChanges();
        }
    }
}
