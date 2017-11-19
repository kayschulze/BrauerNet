namespace BrauerNet.Models
{
    public class ProjectStakeholder
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int StakeholderId { get; set; }
        public Stakeholder Stakeholder { get; set; }
    }
}
