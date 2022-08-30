using LanZhouBeefNoodles.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanZhouBeefNoodles
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();//注入内置的组件

            //注入方法1：每次发起请求的时候都创建一个全新的实例
            services.AddTransient<INoodleRepository, MockNoodleRepository>();
            services.AddTransient<IFeedbackRepository, MockFeedbackRepository>();
            //注入方法2：每次发起请求的时候有且仅创建一个实例
            //services.AddSingleton<INoodleRepository, MockNoodleRepository>();

            //注入方法3：
            //services.AddScoped<INoodleRepository, MockNoodleRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();//启用路由（Conventional routing）
                //endpoints.MapControllers();//启用路由（Attribute routing）

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=home}/{action=index}/{id?}"
                    );

                //endpoints.MapGet("/a", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World! I'm A!");
                //});
                //endpoints.MapGet("/b", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World! I'm B!");
                //});
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
        }
    }
}
