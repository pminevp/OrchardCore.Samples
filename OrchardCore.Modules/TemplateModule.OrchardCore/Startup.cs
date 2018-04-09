using System;
#if (AddPart)
using TemplateModule.OrchardCore.Drivers;
using TemplateModule.OrchardCore.Handlers;
using TemplateModule.OrchardCore.Models;
using TemplateModule.OrchardCore.Settings;
#endif
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
#if (AddPart)
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
#endif
using OrchardCore.Modules;

namespace TemplateModule.OrchardCore
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
#if (AddPart)
            services.AddScoped<IContentPartDisplayDriver, MyTestPartDisplayDriver>();
            services.AddSingleton<ContentPart, MyTestPart>();
            services.AddScoped<IContentPartDefinitionDisplayDriver, MyTestPartSettingsDisplayDriver>();
            services.AddScoped<IDataMigration, Migrations>();
            services.AddScoped<IContentPartHandler, MyTestPartHandler>();
#endif
        }

        public override void Configure(IApplicationBuilder builder, IRouteBuilder routes, IServiceProvider serviceProvider)
        {
        }
    }
}