using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityPOC.API.Extensions;
using EntityPOC.Data.DatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using EntityPOC.Data.Migrations;
using System.Text.Json.Serialization;

namespace EntityPOC.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers().AddJsonOptions(options => 
            //    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve
            //);

            services.AddControllers();

            services.ConfigureSwaggerService();

            var connectionString = Configuration.GetConnectionString("Default");
            var databaseServerVersion = Configuration.GetSection("DatabaseServerVersion");

            services.AddEntityFramework(connectionString, databaseServerVersion.Value);
            services.AddAutoMapper();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.ConfigureSwagger();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
