using Microsoft.Extensions.Localization;
using Volo.Abp.Domain.Repositories;

namespace Localization
{
    public interface IAppLocalizationRepository : IRepository<LocalizedResource, int>
    {
        Task<LocalizedString> GetLocalizedText(string resource, string cultureName, string name);
        Task<List<LocalizedResource>> GetList(string resource, string cultureName);
    }
}
