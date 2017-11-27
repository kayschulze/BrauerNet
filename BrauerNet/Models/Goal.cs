using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Goals")]

    public class Goal
    {
        [Key]
        public int GoalId { get; set; }
        public string Description { get; set; }

        public virtual List<GoalProject> GoalProjects { get; set; }
        //public List<Project> Projects { get; set; }

        public Goal() { }

        public Goal(string description)
        {
            Description = description;
        }
    }
}
