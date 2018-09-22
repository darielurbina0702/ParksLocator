using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ParksLocator.Clients;
using ParksLocator.Clients.Interfaces;
using ParksLocator.Options;
using ParksLocator.Repositories;
using ParksLocator.Repositories.Interfaces;
using ParksLocator.Services;
using ParksLocator.Services.Interfaces;

namespace ParksLocator
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

            services.AddMvc()           
            .AddJsonOptions(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.Configure<GoogleApiSettings>(Configuration.GetSection("GoogleApiSettings"));

            services.AddScoped<IParksLocatorService, ParksLocatorService>();
            services.AddScoped<IParksLocatorRepository, ParksLocatorRepository>();
            services.AddScoped<IGoogleApiClient, GoogleApiClient>();
            services.AddScoped<IDistanceService,DistanceService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
