using Chat.DataAccess.Abstractions.Repository;
using Chat.DataAccess.Abstractions.UnitOfWork;
using Chat.DataAccess.ORM.EntityFramework;
using Chat.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chat.DataAccess
{
    public static class Extensions
    {
        public static void AddDataAccess(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.Configure<DatabaseOptions>(configuration.GetSection(DatabaseOptions.SectionName));

            serviceCollection.AddDbContext<ChatDbContext>((serviceProvider, options) =>
            {
                var databaseOptions = serviceProvider
                                    .GetRequiredService<IOptions<DatabaseOptions>>()
                                    .Value;

                options.UseSqlServer(databaseOptions.ConnectionString);
            });

            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }           
    }
}
