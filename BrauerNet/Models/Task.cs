using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrauerNet.Models
{
    [Table("Tasks")]

    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public string Description { get; set; }
        public virtual Team Team { get; set; }
        public bool Completed { get; set; }
    }
}
