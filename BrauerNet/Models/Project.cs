using System;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    public class Project
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
            public List<Participant> Students { get; set; }
            public List<Participant> Mentors { get; set; }
            public List<Participant> Teachers { get; set; }
        }
    }
}
