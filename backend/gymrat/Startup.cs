using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymrat.Component.Rat;
using Gymrat.Data;
using Gymrat.Data.Repository.Core;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace gymrat
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
            services.AddGraphQL(
                SchemaBuilder.New()
                 .AddQueryType<RatQueryType>()
            .Create());
            services.AddControllers();
            services.AddDbContext<GymEntityContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("GymratConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRatQueries, RatQueries>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseGraphQL();
            app.UsePlayground();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
