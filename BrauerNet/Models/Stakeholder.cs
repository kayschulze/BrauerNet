using System.ComponentModel.DataAnnotations.Schema;

namespace BrauerNet.Models
{
    [Table("Stakeholders")]

    public class Stakeholder
    {
        public int StakeholderId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
