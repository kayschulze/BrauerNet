using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Participants")]
    public class Participant : IdentityUser
    {
        [Key]
        public int ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; } (inherited)
        //public string PhoneNumber { get; set; } (inherited)
        public List<Project> Projects { get; set; }
    }
}
