using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFProjectRepository
    {
        BrauerNetDbContext db;

        public EFProjectRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Project> Projects
        { get { return db.Projects; } }

        public Project Save(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }

        public Project Edit(Project project)
        {
            db.Entry(project).State = EntityState.Modified;
            db.SaveChanges();
            return project;
        }

        public void Remove(Project project)
        {
            db.Projects.Remove(project);
            db.SaveChanges();
        }
    }
}
