using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace EntityPOC.API.Extensions
{
	public static class SwaggerExtensions
	{
		public static void ConfigureSwaggerService(this IServiceCollection services)
		{
			services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Entity POC Api",
					Description = "A sexy API description",
					TermsOfService = new Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ"),
					Contact = new OpenApiContact()
					{
						Name = "Fancy developer",
						Url = new Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
					},
					License = new OpenApiLicense()
					{
						Name = "No license",
						Url = new Uri("https://www.youtube.com/watch?v=dQw4w9WgXcQ")
					}
				});
			});
		}

		public static void ConfigureSwagger(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(options =>
			{
				options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
				options.RoutePrefix = string.Empty;
			});
		}
	}
}
