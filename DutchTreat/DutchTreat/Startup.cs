using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DutchTreat
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Tell me how you want to start up.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //  if (env.IsDevelopment())
            //  {
            //      app.UseDeveloperExceptionPage();
            //  }

            //app.Run(async (context) =>
            //{
            // returns a simple request.
            //await context.Response.WriteAsync("Hello World!");

            //or write a web page in this request. 
            //  await context.Response.WriteAsync("<html><body><h1>Hello World!</h1></body></html>");
            //});

            //This still won't work until the html pages are within the wwwwroot. 
            //You're setting up the order of the middleware. Middleware is "when a request comes in, I want you to run some code."
            //The order matters. Be careful.
            app.UseDefaultFiles(); //middleware looks for a blank directory url. It's going to search in that structure, look in wwwwroot and see if there is a default, or index.html. It 
            //changes the path to that file. Then passes to the next piece of middlware.
            app.UseStaticFiles(); 
        }


    }
}
