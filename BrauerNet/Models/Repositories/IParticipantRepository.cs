using System.Linq;

namespace BrauerNet.Models
{
    public interface IParticipantRepository
    {
        IQueryable<Participant> Participants { get; }
        Participant Save(Participant participant);
        Participant Edit(Participant participant);
        void Remove(Participant participant);
    }
}
