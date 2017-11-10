using System.Linq;

namespace BrauerNet.Models
{
    public interface IStakeholderRepository
    {
        IQueryable<Stakeholder> Stakeholders { get; }
        Stakeholder Save(Stakeholder stakeholder);
        Stakeholder Edit(Stakeholder stakeholder);
        void Remove(Stakeholder stakeholder);
    }
}