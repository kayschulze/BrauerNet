<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrauerNet.Models
{
    public class Standard
    {
=======
﻿using System.ComponentModel.DataAnnotations;
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


>>>>>>> ae1cbc95bb978b159ac156a92de16d795b878e9a
    }
}
