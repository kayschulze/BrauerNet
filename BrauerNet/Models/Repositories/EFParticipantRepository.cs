using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFParticipantRepository : IParticipantRepository
    {
        BrauerNetDbContext db;

        public EFParticipantRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Participant> Participants
        { get { return db.Participants; } }

        public Participant Save(Participant participant)
        {
            db.Participants.Add(participant);
            db.SaveChanges();
            return participant;
        }

        public Participant Edit(Participant participant)
        {
            db.Entry(participant).State = EntityState.Modified;
            db.SaveChanges();
            return participant;
        }

        public void Remove(Participant participant)
        {
            db.Participants.Remove(participant);
            db.SaveChanges();
        }
    }
}
