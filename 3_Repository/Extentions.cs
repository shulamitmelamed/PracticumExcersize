using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Repository
{
    public static class Extentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IDataSource, SQLDataSource>();
            services.AddScoped<IPersonalDetailsRepository, PersonalDetailsRepository>();
            services.AddScoped<IChildrenRepository, ChildrensRepository>();

            return services;
        }
    }
}
