using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Stakeholders")]

    public class Stakeholder
    {
        [Key]
        public int StakeholderId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public virtual List<ProjectStakeholder> ProjectStakeholders { get; set; }

        public Stakeholder() { }

        public Stakeholder(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
