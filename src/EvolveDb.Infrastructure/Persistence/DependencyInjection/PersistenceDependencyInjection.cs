using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvolveDb.Application.Interfaces;
using EvolveDb.Infrastructure.Persistence.AppSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EvolveDb.Infrastructure.Persistence.DependencyInjection
{
    public static class PersistenceDependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ConnectionStringSettings>(configuration.GetSection(ConnectionStringSettings.Section));
            //services.AddScoped(typeof(IGenericCrudRepository<,>), typeof(GenericCrudRepository<,>));
           
            return services;
        }
    }
}
