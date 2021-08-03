using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvolveDb.Infrastructure.Persistence;
using EvolveDb.Infrastructure.Persistence.AppSettings;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EvolveDb.Api
{

    internal static class RunDbMigrations
    {
        internal static ILogger _logger;
        internal static void Run(IHost host)
        {
            // Run db Migrations
            var options = GetDbOptions(host);

            //var serviceProvider = PersistenceDbMigrations.CreateServices(options.DbConnectionString, options.Tags);

            PersistenceDbMigrations.EnsureDatabase(options.MasterDb, options.MainDbName);

            //// Put the database update into a scope to ensure that all resources will be disposed.
            //using var scope = serviceProvider.CreateScope();

            //PersistenceDbMigrations.UpdateDatabase(scope.ServiceProvider);
        }

        private static DbOptions GetDbOptions(IHost host)
        {
            var options = new DbOptions();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                var config = services.GetRequiredService<IConfiguration>();
                _logger = loggerFactory.CreateLogger("RunDbMigrations");
                options.DbConnectionString = config.GetConnectionString("Database");
                options.MasterDb = config.GetConnectionString("Master");
                options.MainDbName = config.GetSection(DbOptionsSettings.MainDbName).Value;
                _logger.LogInformation("Retrieved Db Options");
            }
            return options;
        }
    }
}
