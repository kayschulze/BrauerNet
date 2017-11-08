using System;
namespace BrauerNet.Models
{
    public class IStakeholderRepository
    {
        IQueryable<Stakeholder> Stakeholders { get; }
        Group Save(Stakeholder stakeholder);
        Group Edit(Stakeholder stakeholder);
        void Remove(Stakeholder stakeholder);
    }
}