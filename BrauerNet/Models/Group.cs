<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.Collections.Generic;
>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a

namespace BrauerNet.Models
{
    public class Group
    {
<<<<<<< HEAD
=======
        [Table("Groups")]

        public class Group
        {
            public int GroupId { get; set; }
            public List<Participant> Students { get; set; }
            public List<Participant> Mentors { get; set; }
            public List<Participant> Teachers { get; set; }
        }
>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a
    }
}
