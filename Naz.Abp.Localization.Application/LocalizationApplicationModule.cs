using Localization.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Localization.Application
{
    [DependsOn(typeof(LocalizationApplicationContractsModule))]
    public class LocalizationApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LocalizationApplicationModule>();
            });
        }
    }
}
