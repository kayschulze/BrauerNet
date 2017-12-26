using System.Linq;

namespace BrauerNet.Models
{
    public interface IGoalRepository
    {
        IQueryable<Goal> Goals { get; }
        Goal Save(Goal goal);
        Goal Edit(Goal goal);
        void Remove(Goal goal);
    }
}
