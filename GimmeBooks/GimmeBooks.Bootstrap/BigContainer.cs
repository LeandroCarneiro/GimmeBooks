using GimmeBooks.Application.AppServices;
using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Business.Domain;
using GimmeBooks.Data.Contexts;
using GimmeBooks.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GimmeBooks.Bootstrap
{
    public static class BigContainer
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection service)
        {
            service.AddTransient<NewsAppService>();
            return service;
        }

        public static IServiceCollection RegisterAppBusiness(this IServiceCollection service)
        {
            service.AddTransient<INewBusiness, NewsBusiness>();
            return service;
        }

        public static IServiceCollection RegisterAppPersistence(this IServiceCollection service)
        {
            service.AddDbContext<AppDbContext>();
            service.AddTransient<IDbContext, AppDbContext>();
            return service;
        }
    }
}
