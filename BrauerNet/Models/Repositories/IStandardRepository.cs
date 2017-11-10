using System;
namespace BrauerNet.Models
{
    public class IStandard
    {
        IQueryable<Standard> Standards { get; }
        Group Save(Standard standard);
        Group Edit(Standard standard);
        void Remove(Standard standard);
    }
}
