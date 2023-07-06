using GimmeBooks.Domain.Entities;
using GimmeBooks.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GimmeBooks.Data.Contexts
{
    public class AppDbContext : BaseContext, IDbContext
    {
        public virtual DbSet<NewsAnalitics> tblNewsAnalitics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("AppDB"));
            base.OnConfiguring(options);

            options.UseLoggerFactory(_loggerFactory);
        }
    }
}
