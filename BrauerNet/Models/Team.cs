using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Teams")]

    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Participant> Members { get; set; }
    }
}
