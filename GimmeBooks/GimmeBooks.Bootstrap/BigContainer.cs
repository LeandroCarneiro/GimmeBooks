using GimmeBooks.Application.AppServices;
using GimmeBooks.Application.Interfaces.Business;
using GimmeBooks.Application.Interfaces.Services;
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
            service.AddTransient<BookAppService>();
            return service;
        }

        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            service.AddTransient<INewsSearcher, NYNews.Client>();
            service.AddTransient<IBookSearcher, GoogleBooks.Client>();
            service.AddTransient<ITweetSearcher, Twitter.Client>();

            return service;
        }

        public static IServiceCollection RegisterAppBusiness(this IServiceCollection service)
        {
            service.AddTransient<INewBusiness, NewsBusiness>();
            service.AddTransient<IBookBusiness, BookBusiness>();

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
