using AutoMapper;
using EntityPOC.API.DTOs;
using EntityPOC.Data.DatabaseContext;
using EntityPOC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace EntityPOC.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private const string MigrationsAssembly = "EntityPOC.Data.Migrations";

        public static void AddEntityFramework(this IServiceCollection serviceCollection, string connectionString, string databaseServerVersion)
        {
            var serverVersion = new MySqlServerVersion(databaseServerVersion);

            serviceCollection.AddDbContext<KanbanDatabaseContext>(
                options => options
                    .UseMySql(connectionString, serverVersion, x => x.MigrationsAssembly(MigrationsAssembly))
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors()
                    .UseLazyLoadingProxies()
                );
        }

        public static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
           serviceCollection.AddAutoMapper(typeof(MappingProfile));
        }

        class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Board, BoardOutputDTO>();
                CreateMap<BoardInputDTO, Board>();
            }
        }
    }
}
