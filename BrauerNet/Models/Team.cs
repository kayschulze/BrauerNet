using System.Collections.Generic;

namespace BrauerNet.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Participant> Members { get; set; }
    }
}
