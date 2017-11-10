using System.Linq;

namespace BrauerNet.Models
{
    public interface ITaskRepository
    {
        IQueryable<Task> Tasks { get; }
        Task Save(Task task);
        Task Edit(Task task);
        void Remove(Task task);
    }
}
