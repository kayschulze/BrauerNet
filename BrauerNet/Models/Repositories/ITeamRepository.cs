using System;
namespace BrauerNet.Models
{
    public class ITeamRepository
    {
        IQueryable<Team> Teams { get; }
        Team Save(Team team);
        Team Edit(Team team);
        void Remove(Team team);
    }
}
