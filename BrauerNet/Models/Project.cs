using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
	[Table("Projects")]

    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<string> Goals { get; set; }
        public List<Stakeholder> Stakeholders { get; set; }
        public List<Standard> Standards { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Team> Teams { get; set; }

        public Project() { }

        public Project(string name, List<string> goals, int projectId = 0)
        {
            Name = name;
            Goals = goals;
        }
    }
}
