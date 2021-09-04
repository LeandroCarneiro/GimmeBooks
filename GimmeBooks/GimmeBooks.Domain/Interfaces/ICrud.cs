using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GimmeBooks.Domain.Interfaces
{
    public interface ICrud<T, TIdType>
    {
        TIdType Add(T obj);
        void Update(T obj);
        T FindById(TIdType id);
        T Find(Expression<Func<T, bool>> expression);
        IEnumerable<T> List(Expression<Func<T, bool>> expression);

        IQueryable<T> SetIncluding { get; }
        IQueryable<T> SetIncludingTracking { get; }
    }
}
