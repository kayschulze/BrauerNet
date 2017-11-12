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
        public List<Participant> Students { get; set; }
        public List<Participant> Mentors { get; set; }
        public List<Participant> Teachers { get; set; }
    }
}
