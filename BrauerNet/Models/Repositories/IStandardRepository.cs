using System.Linq;

namespace BrauerNet.Models
{
    public interface IStandardRepository
    {
        IQueryable<Standard> Standards { get; }
        Standard Save(Standard standard);
        Standard Edit(Standard standard);
        void Remove(Standard standard);
    }
}
