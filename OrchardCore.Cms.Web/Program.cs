﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
#if (AddNLog)
using OrchardCore.Logging;
#endif
using OrchardCore.Modules;

namespace OrchardCore.Cms.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
#if (AddNLog)
                .UseNLogWeb()
#endif
                .UseStartup<Startup>()
                .Build();
    }
}
