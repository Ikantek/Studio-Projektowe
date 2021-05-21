using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Security.Principal;
using GymManager.Infrastructure.Acl;
using GymManager.Models;
using Microsoft.AspNetCore.Http;

namespace GymManager
{
    public class Startup
    {
        public const string CookieScheme = "AuthCookie";


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // Sets the default scheme to cookies
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
                {
                    options.AccessDeniedPath = "/";
                    options.LoginPath = "/zaloguj";
                });
            
            services.AddDbContext<DbContext, GymDbContext>(opts =>
            {
                opts.UseNpgsql("Host=kandula.db.elephantsql.com;Database=izknccee;Username=izknccee;Password=MDvv266CzZGjPa3KFulEFs5HEAsn_keg");
                opts.LogTo(Console.WriteLine);
                opts.EnableSensitiveDataLogging();
            });


            services.AddScoped<IPrincipal>(sp =>
            {
                return sp.GetService<IHttpContextAccessor>()?.HttpContext.User;
            });
            services.AddScoped<AclDbContext>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
}
