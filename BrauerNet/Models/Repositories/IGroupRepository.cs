using System.Linq;

namespace BrauerNet.Models
{
    public interface IGroupRepository
    {
        IQueryable<Group> Groups { get; }
        Group Save(Group group);
        Group Edit(Group group);
        void Remove(Group group);
    }
}
