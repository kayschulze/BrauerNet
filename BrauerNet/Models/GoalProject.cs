using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrauerNet.Models
{
    public class GoalProject
    {
        public int GoalId { get; set; }
        public Goal Goal { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
