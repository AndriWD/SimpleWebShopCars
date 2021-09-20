using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop1.Data.DAL;
using WebShop1.Data.Interfaces;
using WebShop1.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using WebShop1.Data.Repository;
using Microsoft.EntityFrameworkCore.Design;
using WebShop1.Data;
using WebShop1.Data.Models;

namespace WebShop1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private IConfigurationRoot configurationString;
        //конструктор
        public Startup(IWebHostEnvironment hostenv)
        {
            configurationString = new ConfigurationBuilder().SetBasePath(hostenv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configurationString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllCars, CarRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddTransient<IAllOrders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(s => Cart.GetCart(s)); //розграничує доступ між користувачами до корзини, тобто робить для кожного користувача унікальну корзину


            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
            
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{Action=Index}/{id?}");
                routes.MapRoute(name: "categoryFilter", template: "Cars/{action}/{category?}", defaults: new { controller = "Cars", Action = "List" });
            });
            
          
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContext db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DbObjects.Initial(db);
            }


            


        }
    }
}
