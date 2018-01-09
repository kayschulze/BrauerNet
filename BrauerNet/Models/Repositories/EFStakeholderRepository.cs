using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace BrauerNet.Models
{
    public class EFStakeholderRepository : IStakeholderRepository
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
            
            using (var db = new BrauerNetDbContext())
            {
                //var Stakeholder = db.Stakeholders.Single(s => s.StakeholderId == 1);
                //Stakeholder.
                //db.Entry(stakeholder).State = EntityState.Modified;
                //stakeholder = db.Stakeholders.FirstOrDefault(s => s.StakeholderId == 1);
                //stakeholder.Name = "Jim";

                db.Database.ExecuteSqlCommand("UPDATE brauernetdb.Stakeholders SET Name=@stakeholder.Name WHERE StakeholderId = @stakeholder.StakeholderId");

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entry in ex.Entries)
                    {
                        if (entry.Entity is Stakeholder)
                        {
                            var databaseEntity = db.Stakeholders.AsNoTracking().SingleAsync(s => s.StakeholderId == ((Stakeholder)entry.Entity).StakeholderId);
                            var databaseEntry = db.Entry(databaseEntity);

                            foreach (var property in entry.Metadata.GetProperties())
                            {
                                var proposedValue = entry.Property(property.Name).CurrentValue;
                                var originalValue = entry.Property(property.Name).OriginalValue;
                                var databaseValue = databaseEntry.Property(property.Name).CurrentValue;

                                // Update original values
                                entry.Property(property.Name).OriginalValue = databaseEntry.Property(property.Name).CurrentValue;
                            }
                        }
                        else
                        {
                            throw new NotSupportedException("Don't know how to handle concurrency conflicts for " + entry.Metadata.Name);
                        }
                    }

                    db.SaveChanges();
                }

                return stakeholder;
            }
        }

        public void Remove(Stakeholder stakeholder)
        {
            db.Stakeholders.Remove(stakeholder);
            db.SaveChanges();
        }
    }
}
