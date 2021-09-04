using GimmeBooks.Domain;
using GimmeBooks.Domain.Interfaces;

namespace GimmeBooks.Application
{
    public interface IBusiness<T> : ICrud<T, long> where T : EntityBase<long>
    {
    }
}
