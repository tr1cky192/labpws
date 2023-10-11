using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection
        services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseSession();
            app.Run(async (context) =>
            {
                if (context.Session.Keys.Contains("name"))
                    await
                    context.Response.WriteAsync($"Hello {context.Session.GetString("name")}!");


            else
                {
                    context.Session.SetString("name","Tom");
                    await
                    context.Response.WriteAsync("Hello World!");
                }
            });
        }
    }
}

