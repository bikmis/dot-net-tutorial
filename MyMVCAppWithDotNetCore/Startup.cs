using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyDataWithEF6.Implementations;
using MyDataWithEF6.Interfaces;
using MyMVCAppWithDotNetCore.Implementations;
using MyMVCAppWithDotNetCore.Interfaces;
using MyMVCAppWithDotNetCore.Services;

namespace MyCoreApp
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
            services.AddControllersWithViews();
            services.AddScoped<IUnitOfWork>(_ => new UnitOfWork(Configuration.GetConnectionString("SchoolDb")));
            services.AddSingleton<ISingletonGuidNumber, GuidNumber>();
            services.AddScoped<IScopedGuidNumber, GuidNumber>();
            services.AddTransient<ITransientGuidNumber, GuidNumber>();
            services.AddTransient<GuidService, GuidService>();
           // services.AddMvc(options => options.EnableEndpointRouting = false);
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); //If you don't mention controller and action, they default to Home and Index. Id is optional as it has a question mark.
            });

            // Use the followoing MVC routing when you set options.EnableEndpointRouting to false in ConfigureServices method
            // app.UseMvcWithDefaultRoute();
            // or
            // app.UseMvc(routes => {routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");});  //id? - ? makes id optional
        }
    }
}
