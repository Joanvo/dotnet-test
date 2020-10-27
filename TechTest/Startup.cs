using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TechTest.Domain;

namespace TechTest
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

            services.AddDbContext<Data.DataContext>(opt => opt.UseInMemoryDatabase("techtestdb"));
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

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetService<Data.DataContext>();
                SeedData(context);
            }
        }

        private static void SeedData(Data.DataContext context)
        {
            //Since we don't have a real database, treat this seed data as the preexisting data in the database
            var robot1 = new Robot
            {
                Id = 1,
                ConditionExpertise = "Kidney Beans"
            };

            context.Robots.Add(robot1);

            var robot2 = new Robot
            {
                Id = 2,
                ConditionExpertise = "Bloaty Head"
            };

            context.Robots.Add(robot2);

            var robot3 = new Robot
            {
                Id = 3,
                ConditionExpertise = "Kidney Beans"
            };

            context.Robots.Add(robot3);

            var robot4 = new Robot
            {
                Id = 4,
                ConditionExpertise = "Infectious Laughter"
            };

            context.Robots.Add(robot4);

            context.SaveChanges();
        }
    }
}
