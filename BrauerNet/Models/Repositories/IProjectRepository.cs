using System;
namespace BrauerNet.Models
{
    public class IProjectRepository
    {
        IQueryable<Project> Projects { get; }
        Project Save(Project project);
        Project Edit(Project project);
        void Remove(Project project);
    }

}
