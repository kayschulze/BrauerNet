using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrauerNet.Models
{
    [Table("Teams")]

    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Participant> Members { get; set; }

        public Team() { }

        public Team(string name)
        {
            Name = name;
        }
    }
}
