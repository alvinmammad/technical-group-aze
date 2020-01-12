using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechnicalGroup.Data;
using TechnicalGroup.Filters;

//using TechnicalGroup.Middlewares;

namespace TechnicalGroup
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private readonly IHttpContextAccessor _context;
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<TechnicalGroupDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionsStrings:Development"]);
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
          options =>
          {
              options.LoginPath = new PathString("/technicalgroupadmin/Account/Login");
              options.AccessDeniedPath = new PathString("/technicalgroupadmin/Account/AccessDined");
          });

            services.AddLocalization(options => options.ResourcesPath = "Resources");



            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new List<CultureInfo>
                 {
                     new CultureInfo("az"),
                     new CultureInfo("en"),
                     new CultureInfo("ru")
                 };

                options.DefaultRequestCulture = new RequestCulture("az");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
            services.AddMvc(options => options.Filters.Add(new GetLanguageActionFilter())

               ).AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
               .AddDataAnnotationsLocalization();
            services.AddMvc()/*SetCompatibilityVersion(CompatibilityVersion.Version_2_2)*/;

            services.AddSession();
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

            app.UseAuthentication();

            app.UseSession();

            //app.UseMiddleware<AuthenticationMiddleware>();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRequestLocalization();

            app.UseCookiePolicy();

            var supportedCultures = new[]
            {
                new CultureInfo("az"),
                new CultureInfo("en"),
                new CultureInfo("ru")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("az"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures

            });

            app.UseMvc(routes =>
            {
           //     routes.MapRoute(
           //      name: "BlogUrl",
           //      template: "{controller=Home}/{action=BlogDetail}/{slug?}"
           //  );
           //     routes.MapRoute(
           //      name: "ProductUrl",
           //      template: "{controller=Home}/{action=ProductDetail}/{slug?}"
           //  );
           //     routes.MapRoute(
           //    name: "ProjectUrl",
           //    template: "{controller=Home}/{action=ProjectDetail}/{slug?}"
           //);

                //Route for Technical Group Admin
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Dashboard}/{action=Index}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
