using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using CarCare.Application.Services;
using CarCare.Application.Services.CarService;
using CarCare.Core.IRepositories;
using CarCare.EntityFrameworkCore;
using CarCare.EntityFrameworkCore.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CarCare
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
            services.AddDbContext<CarCareDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CarCareDB")));
            ConfigureIoC(services);
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddAutoMapper(typeof(Application.Services.CarService.CarProfiles.CarProfile).GetTypeInfo().Assembly);

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "1.0.0",
                    Title = "API Documentation",
                    Description = "Services for Backend",
                    //TermsOfService = new Uri("https://www.procenne.com/Emv&Payment")
                });
                //c.AddSecurityDefinition("Bearer",
                //    new ApiKeyScheme
                //    {
                //        In = "header",
                //        Description = "Please enter into field the word 'Bearer' following by space and JWT",
                //        Name = "Authorization",
                //        Type = "apiKey"
                //    });
                //c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                //{
                //    { "Bearer", Enumerable.Empty<string>() },
                //});
            });
        }

        private static void ConfigureIoC(IServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<ICarMaintainceRepository, CarMaintainceRepository>();
            services.AddTransient<ICarMaintainceService, CarMaintainceService>();
            services.AddTransient<ICarModelRepository, CarModelRepository>();
            services.AddTransient<ICarModelService, CarModelService>();
            services.AddTransient<ICarOwnerRepository, CarOwnerRepository>();
            services.AddTransient<ICarOwnerService, CarOwnerService>();
            


            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json","Swagger");
                    c.RoutePrefix = "";
                });
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
