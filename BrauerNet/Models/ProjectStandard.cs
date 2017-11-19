namespace BrauerNet.Models
{
    public class ProjectStandard
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int StandardId { get; set; }
        public Standard Standard { get; set; }
    }
}
