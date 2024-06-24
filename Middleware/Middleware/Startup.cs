using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Middleware
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>{
            //    await context.Response.WriteAsync("Hello from Middleware 1");
            //    await next();
            //    await context.Response.WriteAsync("Hello from Middleware 1 Response");
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from Middleware 2");
            //    await next();
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from Middleware 3");
            //    await next();
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //app.Run(MyMiddleware);

            app.Map("/customMap", CustomHandleMap);
        }

        private Task MyMiddleware(HttpContext context) {
            return context.Response.WriteAsync("Hello Word from extension method");
        }

        private static void CustomHandleMap(IApplicationBuilder app) {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Map Methode is called");
            });
        }
    }
}
