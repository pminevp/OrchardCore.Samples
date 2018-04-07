using System;
#if (AddPart)
using TemplateModule.OrchardCore.Drivers;
using TemplateModule.OrchardCore.Handlers;
using TemplateModule.OrchardCore.Models;
using TemplateModule.OrchardCore.Settings;
#endif
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
#if (AddPart)
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
#endif

using OrchardCore.Logging;

using OrchardCore.Modules;

namespace OrchardCore.Cms.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOrchardCms();

#if (AddPart)
            services.AddScoped<IContentPartDisplayDriver, MyTestPartDisplayDriver>();
            services.AddSingleton<ContentPart, MyTestPart>();
            services.AddScoped<IContentPartDefinitionDisplayDriver, MyTestPartSettingsDisplayDriver>();
            services.AddScoped<IDataMigration, Migrations>();
            services.AddScoped<IContentPartHandler, MyTestPartHandler>();
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseNLogWeb(loggerFactory, env);
            app.UseModules();
        }
    }
}