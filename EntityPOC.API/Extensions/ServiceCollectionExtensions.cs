using EntityPOC.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace EntityPOC.API.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static void AddEntityFramework(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddDbContext<KanbanDatabaseContext>(
					options => options
							.UseInMemoryDatabase(databaseName: "EntityPOC")
							.LogTo(Console.WriteLine, LogLevel.Information)
							.EnableSensitiveDataLogging()
							.EnableDetailedErrors()
					);
		}
	}
}
