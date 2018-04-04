using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DutchTreat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //console app that listens to web requests, port 80.
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            //default builder for WebHost, tells it what class to use.
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
