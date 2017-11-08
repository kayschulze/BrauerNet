using System;
namespace BrauerNet.Models
{
    public class ITaskRepository
    {
        IQueryable<Task> Tasks { get; }
        Task Save(Task task);
        Task Edit(Task task);
        void Remove(Task task);
    }
}
