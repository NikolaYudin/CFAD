using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CFAD.Data;
using CFAD.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace CFAD
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddRazorPages();
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IQuestionService, QuestionService>();

            //////
            //////  Подключение к базе дынных
            //////
            string connection = Configuration.GetConnectionString("ApplicationContext");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller}");
                endpoints.MapFallbackToPage("/_Host");
            });

        }
    }
}
