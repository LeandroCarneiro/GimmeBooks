using GimmeBooks.Application.AppServices;
using GimmeBooks.Application.Interfaces;
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
            service.AddTransient<SurveyAppService>();
            service.AddTransient<UserAppService>();
            return service;
        }

        public static IServiceCollection RegisterAppBusiness(this IServiceCollection service)
        {
            service.AddTransient<ISurveyBusiness, SurveyBusiness>();
            service.AddTransient<IUserBusiness, UserBusiness>();
            return service;
        }

        public static IServiceCollection RegisterAppPersistence(this IServiceCollection service)
        {
            service.AddDbContext<TeslaDbContext>();
            service.AddTransient<IDbContext, TeslaDbContext>();
            return service;
        }
    }
}
