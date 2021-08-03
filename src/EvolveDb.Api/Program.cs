using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EvolveDb.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            RunDbMigrations.Run(host);

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }

    internal static class RunDbMigrations
    {
        internal static void Run(IHost host)
        {
            // Run db Migrations
            //var options = GetFluentMigratorOptions(host);

            //var serviceProvider = PersistenceDbMigrations.CreateServices(options.DbConnectionString, options.Tags);

            //PersistenceDbMigrations.EnsureDatabase(options.MasterDb, options.MainDbName);

            //// Put the database update into a scope to ensure that all resources will be disposed.
            //using var scope = serviceProvider.CreateScope();

            //PersistenceDbMigrations.UpdateDatabase(scope.ServiceProvider);
        }
    }
}
