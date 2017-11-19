namespace BrauerNet.Models
{
    public class ProjectTask
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
