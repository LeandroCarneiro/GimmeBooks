using GimmeBooks.Bootstrap;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

[assembly: FunctionsStartup(typeof(GimmeBooks.Scheduler.Startup))]
namespace GimmeBooks.Scheduler
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = GetConfiguration();

            DIBootstrap.RegisterTypes(builder.Services);
            //builder.Services.Register(config);
        }

        public static IConfiguration GetConfiguration()
        {
            var current = Directory.GetCurrentDirectory();
            var directories = Directory.GetParent(current)
                .Parent.Parent.Parent.GetDirectories();
            var config = directories.Where(x => x.FullName.Contains("Api"))?.First()?.FullName;

            return new ConfigurationBuilder()
                .SetBasePath(config)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
