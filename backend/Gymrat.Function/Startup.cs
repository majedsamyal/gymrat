using Gymrat.Component.Rat;
using Gymrat.Data;
using Gymrat.Data.Repository.Core;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(Gymrat.Function.Startup))]
namespace Gymrat.Function
{
   public class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureServices(builder.Services);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var configurationRoot = serviceProvider.GetService<IConfiguration>();
            services.AddDbContext<GymEntityContext>(opt => opt.UseNpgsql(configurationRoot.GetConnectionString("GymratConnection")));

            // Add the custom services like repositories etc ...
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRatQueries, RatQueries>();
          
            // Add GraphQL Services
            services.AddGraphQL(sp => SchemaBuilder.New()
                .AddServices(sp)

                // Adds the authorize directive and
                // enable the authorization middleware.
                //.AddAuthorizeDirectiveType()

                .AddQueryType<RatQueryType>()
                .AddMutationType<RatMutationsType>()               
                //.AddMutationType<MutationType>()
                //.AddType<HumanType>()
                //.AddType<DroidType>()
                //.AddType<EpisodeType>()
                .Create(),
                new QueryExecutionOptions
                {
                    TracingPreference = TracingPreference.OnDemand
                });

            // Add Authorization Policy
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("HasCountry", policy =>
            //        policy.RequireAssertion(context =>
            //            context.User.HasClaim(c =>
            //                (c.Type == ClaimTypes.Country))));
            //});
            services.AddAzureFunctionsGraphQL();
        }
    }
}
