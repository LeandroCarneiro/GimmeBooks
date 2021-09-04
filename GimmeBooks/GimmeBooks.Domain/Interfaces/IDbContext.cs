using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace GimmeBooks.Domain.Interfaces
{
    public interface IDbContext : IDisposable
    {
        IDbContextTransaction BeginTransaction();
        void Rollback();
        void Commit();

        DbSet<TEntity> GetEntity<TEntity>() where TEntity : EntityBase<long>;
        EntityEntry EntryEntity<TEntity>(TEntity entity) where TEntity : EntityBase<long>;
    }
}
