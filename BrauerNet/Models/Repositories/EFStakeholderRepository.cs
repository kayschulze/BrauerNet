using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFStakeholderRepository
    {
        BrauerNetDbContext db;

        public EFStakeholderRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Stakeholder> Stakeholders
        { get { return db.Stakeholders; } }

        public Stakeholder Save(Stakeholder stakeholder)
        {
            db.Stakeholders.Add(stakeholder);
            db.SaveChanges();
            return stakeholder;
        }

        public Stakeholder Edit(Stakeholder stakeholder)
        {
            db.Entry(stakeholder).State = EntityState.Modified;
            db.SaveChanges();
            return stakeholder;
        }

        public void Remove(Stakeholder stakeholder)
        {
            db.Stakeholder.Remove(stakeholder);
            db.SaveChanges();
        }
    }
}
