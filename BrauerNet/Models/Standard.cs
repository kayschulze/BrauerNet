using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public Standard() { }


    }
}
