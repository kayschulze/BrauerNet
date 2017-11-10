using System.Linq;

namespace BrauerNet.Models
{
    public interface IStandardRepository
    {
        IQueryable<Standard> Standards { get; }
        Group Save(Standard standard);
        Group Edit(Standard standard);
        void Remove(Standard standard);
    }
}
