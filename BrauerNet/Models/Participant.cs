using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a

namespace BrauerNet.Models
{
    public class Participant : IdentityUser
    {
<<<<<<< HEAD
=======
        public int ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; } (inherited)
        //public string PhoneNumber { get; set; } (inherited)
        public List<Project> Projects { get; set; }
>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a

    }
}
