using System.Linq;

namespace BrauerNet.Models
{
    public interface IProjectRepository
    {
        IQueryable<Project> Projects { get; }
        Project Save(Project project);
        Project Edit(Project project);
        void Remove(Project project);
    }

}
