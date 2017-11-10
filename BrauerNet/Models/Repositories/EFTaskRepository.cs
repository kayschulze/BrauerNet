using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BrauerNet.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        BrauerNetDbContext db;

        public EFTaskRepository(BrauerNetDbContext connection = null)
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

        public IQueryable<Task> Tasks
        { get { return db.Tasks; } }

        public Task Save(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
            return task;
        }

        public Task Edit(Task task)
        {
            db.Entry(task).State = EntityState.Modified;
            db.SaveChanges();
            return task;
        }

        public void Remove(Task task)
        {
            db.Tasks.Remove(task);
            db.SaveChanges();
        }
    }
}
