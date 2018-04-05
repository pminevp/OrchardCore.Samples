using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TemplateModule.OrchardCore.Settings
{
    public class MyTestPartSettingsViewModel
    {
        public string MySetting { get; set; }

        [BindNever]
        public MyTestPartSettings MyTestPartSettings { get; set; }
    }
}
