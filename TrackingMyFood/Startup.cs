using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Tracking.Data.Database;
using Tracking.Data.DataLayer;
using Tracking.Services.Services;
using TrackingMyFoodAPI.AutoMapper;

namespace TrackingMyFood
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
            services.AddControllers();

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);


            services.AddAutoMapper(typeof(Startup));


            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            // Database
            var optionsBuilder = new DbContextOptionsBuilder<MainContext>()
                .UseSqlServer(Configuration["ConnectionString:DB"]);

            var context = new MainContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            services.AddLogging()
              .AddSingleton(configuration)
              .AddSingleton(optionsBuilder.Options)
              .AddTransient<ICompanyService, CompanyService>()

              .AddTransient<ICompanyDataProvider, CompanyDataProvider>()


              .AddDbContextPool<MainContext>(options => options.UseSqlServer(Configuration["ConnectionString:DB"]))
              .BuildServiceProvider();
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}