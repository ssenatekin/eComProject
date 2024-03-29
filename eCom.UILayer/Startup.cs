using eCom.BusinessLayer.Abstract;
using eCom.BusinessLayer.Concrete;
using eCom.DataAccessLayer.Abstract;
using eCom.DataAccessLayer.Concrete;
using eCom.DataAccessLayer.EntityFramework;
using eCom.DataAccessLayer.Repository;
using eCom.EntityLayer.Concrete;
using eCom.UILayer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCom.UILayer
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
            services.AddScoped<IItemService, ItemManager>();
            services.AddScoped<IItemDal, EFItemDal>();

            services.AddScoped<IBasketService, BasketManager>();
            services.AddScoped<IBasketDal, EFBasketDal>();

            services.AddScoped<IBasketItemService, BasketItemManager>();
            services.AddScoped<IBasketItemDal, EFBasketItemDal>();

            services.AddScoped<IBItemService,BItemManager>();
            services.AddScoped<IBItemDal,EFBItemDal>();

            services.AddDbContext<Context>();

            //services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            

            services.AddIdentity<AppUser, AppRole>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

            services.AddControllersWithViews();

            services.AddHttpContextAccessor();

            services.AddSession();
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

            app.UseSession();

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

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
