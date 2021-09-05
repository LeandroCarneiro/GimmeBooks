using GimmeBooks.Domain.Entities;
using GimmeBooks.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GimmeBooks.Data.Contexts
{
    public class AppDbContext : BaseContext, IDbContext
    {
        public virtual DbSet<Book> tblBooks { get; set; }
        public virtual DbSet<News> tblNews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("TeslaDB"));
            base.OnConfiguring(options);

            options.UseLoggerFactory(_loggerFactory);
        }
    }
}
