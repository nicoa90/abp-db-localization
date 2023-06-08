using Localization.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Threading;

namespace Localization.Repositories
{
    public class AppLocalizationRepository : EfCoreRepository<ILocalizationDbContext, LocalizedResource, int>, IAppLocalizationRepository
    {
        public AppLocalizationRepository(IDbContextProvider<ILocalizationDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public Task<List<LocalizedResource>> GetList(string resource = null, string cultureName = null)
        {
            return GetListAsync(s => s.Resource == resource && s.CultureName == cultureName);
        }

        public async Task<LocalizedString> GetLocalizedText(string resource, string cultureName, string name)
        {
            var text = await this.FirstOrDefaultAsync(s => s.Resource == resource && s.Key == name && s.CultureName == cultureName);
            if (text == null)
                return null;

            return text.GetLocalizedString(cultureName);
        }
    }
}
