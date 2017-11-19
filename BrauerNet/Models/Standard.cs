using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Standards")]

    public class Standard
    {
        [Key]
        public int StandardId { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }

        public virtual List<ProjectStandard> ProjectStandards { get; set; }

        public Standard() { }

        public Standard(string type, string identifier, string description)
        {
            Type = type;
            Identifier = identifier;
            Description = description;
        }
    }
}
