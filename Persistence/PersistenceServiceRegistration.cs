﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DatabaseContext;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HRDatabaseContext>(Options =>
        {
            Options.UseSqlServer(configuration.GetConnectionString("HrDatabaseConnectionString"));
        });

        return services;
    }
}
