<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrauerNet.Models
{
    public class Team
    {
=======
﻿using System.Collections.Generic;

namespace BrauerNet.Models
{
    [Table("Teams")]

    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Participant> Members { get; set; }
>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a
    }
}
