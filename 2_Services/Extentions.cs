using _2_Services.Models;
using _3_Repository;
using _3_Repository.Entities;
using _3_Repository.Interfaces;
using _3_Repository.Repositories;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using _2_Services.Interfaces;
using _2_Services.Services;

namespace _2_Services
{
    public static class Extentions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
            services.AddScoped<IChildrenService, ChildrenService>();

            return services;
        }
    }
}