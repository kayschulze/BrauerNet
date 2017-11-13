using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrauerNet.Models
{
    [Table("Goals")]

    public class Goal
    {
        [Key]
        public int GoalId { get; set; }
        public string Description { get; set; }

        public Goal() { }

        public Goal(string description)
        {
            Description = description;
        }
    }
}
