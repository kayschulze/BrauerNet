using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Groups")]

    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public virtual List<Participant> Students { get; set; }
        public virtual List<Participant> Mentors { get; set; }
        public virtual List<Participant> Teachers { get; set; }

        public Group() { }

        public Group(string name)
        {
            Name = name;
        }
    }
}
