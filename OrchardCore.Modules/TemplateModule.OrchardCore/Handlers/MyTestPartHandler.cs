using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;
using TemplateModule.OrchardCore.Models;

namespace TemplateModule.OrchardCore.Handlers
{
    public class MyTestPartHandler : ContentPartHandler<MyTestPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, MyTestPart part)
        {
            part.Show = true;

            return Task.CompletedTask;
        }
    }
}