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
        public virtual List<ProjectStakeholder> ProjectStakeholders { get; set; }
        public virtual List<ProjectStandard> ProjectStandards { get; set; }
        public virtual List<ProjectTask> ProjectTasks { get; set; }
        public virtual List<ProjectTeam> ProjectTeams { get; set; }

        public Project() { }

        public Project(string name, List<GoalProject> goals, int projectId = 0)
        {
            Name = name;
            GoalProjects = goals;
        }
    }
}
