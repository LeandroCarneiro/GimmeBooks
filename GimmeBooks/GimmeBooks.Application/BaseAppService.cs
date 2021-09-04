using GimmeBooks.Common.Exceptions;
using GimmeBooks.Domain;
using GimmeBooks.Mapping;
using GimmeBooks.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace GimmeBooks.Application
{
    public class BaseAppService<T_vw, T>
        where T_vw : EntityBase_vw<long>
        where T : EntityBase<long>
    {
        protected readonly IBusiness<T> _baseBusiness;

        public BaseAppService(IBusiness<T> business)
        {
            _baseBusiness = business;
        }

        public virtual long Add(T_vw obj)
        {
            return _baseBusiness.Add(Resolve(obj));
        }

        public virtual void Update(T_vw obj)
        {
            _baseBusiness.Update(Resolve(obj));
        }

        public virtual T_vw FindById(long id)
        {
            return Resolve(_baseBusiness.SetIncluding.SingleOrDefault(x => x.Id == id));
        }

        #region resolver
        protected T_vw Resolve(T entity)
        {
            if (entity == null)
                throw new InvalidObjectException();

            return MappingWraper.Map<T, T_vw>(entity);
        }
        protected T Resolve(T_vw viewModel)
        {
            if (viewModel == null)
                throw new InvalidObjectException();

            return MappingWraper.Map<T_vw, T>(viewModel);
        }

        protected TTo Resolve<TFrom, TTo>(TFrom entity) where TFrom : EntityBase_vw<long> where TTo : EntityBase<long>
        {
            if (entity == null)
                throw new InvalidObjectException();

            return MappingWraper.Map<TFrom, TTo>(entity);
        }

        protected IEnumerable<T_vw> Resolve(IEnumerable<T> entity)
        {
            if (entity == null)
                throw new InvalidObjectException();

            return MappingWraper.Map<IEnumerable<T>, IEnumerable<T_vw>>(entity);
        }
        protected IEnumerable<T> Resolve(IEnumerable<T_vw> viewModel)
        {
            if (viewModel == null)
                throw new InvalidObjectException();

            return MappingWraper.Map<IEnumerable<T_vw>, IEnumerable<T>>(viewModel);
        }
        #endregion
    }
}
