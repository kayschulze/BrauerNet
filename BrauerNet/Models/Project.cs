using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;

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
        public List<Standard> ProjectStandards { get; set; }
        public List<Participant> Students { get; set; }
        public List<Participant> Mentors { get; set; }
        public List<Participant> Coaches { get; set; }
        public List<Task> Tasks { get; set; }
        public List<Team> Teams { get; set; }

    }
}
