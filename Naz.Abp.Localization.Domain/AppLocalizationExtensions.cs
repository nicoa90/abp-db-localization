using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Localization;
using Volo.Abp;
using System.Diagnostics.CodeAnalysis;

namespace Localization;
public static class AppLocalizationExtensions
{
    public static LocalizationResourceBase AddDatabase([NotNull] this LocalizationResourceBase localizationResource, string resourceName)
    {
        Check.NotNull(localizationResource, nameof(localizationResource));

        localizationResource.Contributors.Add(new DatabaseLocalizationResourceContributor(resourceName));

        return localizationResource;
    }
}
