using System;
namespace BrauerNet.Models
{
    public class IParticipantRepository
    {
        IQueryable<Participant> Participants { get; }
        Participant Save(Participant participant);
        Participant Edit(Participant participant);
        void Remove(Participant participant);
    }
}
