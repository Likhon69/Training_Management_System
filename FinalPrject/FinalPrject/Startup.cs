using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FinalPrject.Utilities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainingManagement.Database.Database;
using TrainingManagement.Manager;
using TrainingManagement.Manager.Contracts;
using TrainingManagement.Repository;
using TrainingManagement.Repository.Contracts;

namespace FinalPrject
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddTransient<ITraineeManager,TraineeManager>();
            services.AddTransient<ITraineeRepository, TraineeRepository>();
            services.AddTransient<DbContext, TraineeDatabaseContext>();
            services.AddTransient<ICourseManager, CourseManager>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<IDepartmentManager,DepartmentManager>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IUtitlityManager, UtilityManager>();
            services.AddDbContext<TraineeDatabaseContext>(optionBuilder =>
                optionBuilder.UseSqlServer("Server=DESKTOP-OF3VVDD\\SQLEXPRESS;Database=Trainee_Management;Trusted_Connection=true")
            );

            services.AddAutoMapper();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
