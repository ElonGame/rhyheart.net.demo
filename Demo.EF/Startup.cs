using System.Reflection;
using Demo.EF.Dbs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Demo.EF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContextPool<TestDbContext>(options =>
                {
                    options.UseMySQL(Configuration.GetConnectionString("TestDbContext"));
                });

            services.AddSwaggerGen(options =>
            {
                var assemblyName = Assembly.GetEntryAssembly().GetName().Name;
                options.SwaggerDoc("v1", new Info
                {
                    Title = assemblyName,
                    Version = "v1"
                });
                options.IncludeXmlComments($"{assemblyName}.xml");
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            app.UseMvc();
        }
    }
}
