using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Tasks")]

    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public virtual List<Project> Projects { get; set; }

        public Task() { }

        public Task(string description, bool completed, int teamid)
        {
            Description = description;
            Completed = completed;
            TeamId = teamid;
        }
    }
}
