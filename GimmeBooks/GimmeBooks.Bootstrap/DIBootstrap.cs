using GimmeBooks.Data.Contexts;
using GimmeBooks.DI;
using GimmeBooks.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GimmeBooks.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterTypes(IServiceCollection service)
        {
            service.RegisterAppServices()
                .RegisterAppBusiness()
                .RegisterAppPersistence();

            AppContainer.SetContainer(service);
            AutoMapperConfiguration.Register();

            Migrate(service);
        }

        private static void Migrate(IServiceCollection services)
        {
            var dao = services.BuildServiceProvider().GetService<AppDbContext>();
            dao.Database.EnsureCreated();
            //dao.Database.Migrate();
        }
    }
}