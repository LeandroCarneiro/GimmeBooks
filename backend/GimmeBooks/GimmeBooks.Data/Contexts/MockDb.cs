using GimmeBooks.Domain.Entities;
using GimmeBooks.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GimmeBooks.Data.Contexts
{
    class MockDb : BaseContext, IDbContext
    {
        public virtual DbSet<NewsAnalitics> tblNewsAnalitics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("GimmeBooksDB");
            base.OnConfiguring(options);

            options.UseLoggerFactory(_loggerFactory);
        }
    }
}
