using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
	[Table("Projects")]

    public class Project
    {
        //BrauerNetDbContext db = new BrauerNetDbContext();

        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public virtual List<GoalProject> GoalProjects { get; set; }
        public virtual List<Stakeholder> Stakeholders { get; set; }
        public virtual List<Standard> Standards { get; set; }
        public virtual List<Task> Tasks { get; set; }
        public virtual List<Team> Teams { get; set; }

        public Project() { }

        public Project(string name, List<GoalProject> goals, int projectId = 0)
        {
            Name = name;
            GoalProjects = goals;
        }
    }
}
