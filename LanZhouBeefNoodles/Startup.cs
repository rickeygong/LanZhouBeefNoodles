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
            services.AddMvc();//ע�����õ����

            //ע�뷽��1��ÿ�η��������ʱ�򶼴���һ��ȫ�µ�ʵ��
            services.AddTransient<INoodleRepository, MockNoodleRepository>();
            services.AddTransient<IFeedbackRepository, MockFeedbackRepository>();
            //ע�뷽��2��ÿ�η��������ʱ�����ҽ�����һ��ʵ��
            //services.AddSingleton<INoodleRepository, MockNoodleRepository>();

            //ע�뷽��3��
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
                //endpoints.MapDefaultControllerRoute();//����·�ɣ�Conventional routing��
                //endpoints.MapControllers();//����·�ɣ�Attribute routing��

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
