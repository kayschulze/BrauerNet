using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrauerNet.Models
{
    //[Table("GoalProjects")]

    public class GoalProject
    {
        [Key]
        public virtual int GoalId { get; set; }
        public virtual Goal Goal { get; set; }

        public virtual int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
