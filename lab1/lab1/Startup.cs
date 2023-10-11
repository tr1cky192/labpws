using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection
 services)
        {
        }
        public void Configure(IApplicationBuilder app)
        {
            int x = 2;
            app.Run(async (context) =>
            {
                x = x + 2; 
                await context.Response.WriteAsync($"Result: {x} ");

            });
        }
    }
}
