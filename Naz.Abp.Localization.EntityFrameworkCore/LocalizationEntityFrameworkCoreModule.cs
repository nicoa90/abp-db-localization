using Localization.Domain;
using Localization.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Localization.EntityFrameworkCore
{
    [DependsOn(
        typeof(LocalizationDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
)]
    public class LocalizationEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LocalizationDbContext>(options =>
            {
                options.AddDefaultRepositories<ILocalizationDbContext>();
                options.AddRepository<LocalizedResource, AppLocalizationRepository>();
            });
        }
    }
}
