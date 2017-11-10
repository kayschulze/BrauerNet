using System.Linq;

namespace BrauerNet.Models
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
        Team Save(Team team);
        Team Edit(Team team);
        void Remove(Team team);
    }
}
