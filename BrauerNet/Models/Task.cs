using System;
namespace BrauerNet.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }
        public virtual Team Team { get; set; }
        public Boolean Completed { get; set; }
    }
}
