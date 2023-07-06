using GimmeBooks.DI;
using GimmeBooks.Domain;
using GimmeBooks.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GimmeBooks.Business.Domain
{
    public abstract class AppBusiness<TEntity> : ICrud<TEntity, long> where TEntity : EntityBase<long>
    {
        protected readonly IDbContext _uow;
        protected DbSet<TEntity> Set;

        public virtual IQueryable<TEntity> SetIncluding => Set.AsNoTracking();
        public virtual IQueryable<TEntity> SetIncludingTracking => Set.AsTracking();

        public AppBusiness()
        {
            _uow = AppContainer.Resolve<IDbContext>();
            Set = _uow.GetEntity<TEntity>();
        }

        public long Add(TEntity obj)
        {
            using (var trans = _uow.BeginTransaction())
            {
                _uow.GetEntity<TEntity>().Add(obj);
                trans.Commit();
                _uow.Commit();

                return obj.Id;
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> expression)
        {
            return Set.SingleOrDefault(expression);
        }

        public TEntity FindById(long id)
        {
            return Set.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TEntity> List(Expression<Func<TEntity, bool>> expression)
        {
            return Set.Where(expression).ToList();
        }

        public void Update(TEntity obj)
        {
            if (obj == null)
                return;

            using (var trans = _uow.BeginTransaction())
            {
                var exist = _uow.GetEntity<TEntity>().SingleOrDefault(x => x.Id == obj.Id);
                if (exist != null)
                {
                    _uow.EntryEntity(obj).CurrentValues.SetValues(obj);
                    _uow.Commit();
                }
            }
        }

        public void Dispose()
        {
            _uow.Dispose();
        }
    }
}