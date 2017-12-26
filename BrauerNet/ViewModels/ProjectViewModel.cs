using BrauerNet.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace BrauerNet.ViewModels
{
    public class ProjectViewModel
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public List<Goal> Goals { get; set; }
    }
}
