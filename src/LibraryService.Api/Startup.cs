using LibraryService.Infrastructure.Ef;
using LibraryService.Infrastructure.Extensions;
using LibraryService.Infrastructure.Ioc;
using LibraryService.Infrastructure.Settings;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace LibraryService.Api
{
    public class Startup
    {
        readonly string AllowedSpecificOrigins = "_allowedSpecificOrigins";

        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var jwtSettings = Configuration.GetSettings<JwtSettings>();
            var securitySettings = Configuration.GetSettings<SecuritySettings>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: AllowedSpecificOrigins,
                                builder =>
                                {
                                    builder.WithOrigins(securitySettings.CorsAllowedOrigins)
                                        .AllowAnyHeader()
                                        .AllowAnyMethod()
                                        .AllowCredentials();
                                });
            }).AddMemoryCache()
                    .AddControllersWithViews()
                    .AddJsonOptions(options
                        => {
                            options.JsonSerializerOptions.WriteIndented = true;
                            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                        });
            services.AddJwtAuthentication(jwtSettings, securitySettings)
                    .AddAuthorization();

            services.AddEntityFrameworkMySql().AddDbContext<LibraryContext>();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ContainerModule(Configuration));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(AllowedSpecificOrigins)
                .UseAuthentication()
                .UseRouting()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                    {
                        endpoints.MapGet("/", async context =>
                        {
                            await context.Response.WriteAsync("Hello, world!");
                        });
                        endpoints.MapControllers();
                    });
        }
    }
}
