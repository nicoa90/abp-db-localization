using Localization;
using Localization.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Localizations
{
    public class LocalizationsAppService : CrudAppService<LocalizedResource, LocalizedResourceDto, int, LocalizedResourceRequest>, ILocalizationsAppService
    {
        public LocalizationsAppService(IRepository<LocalizedResource, int> repository) : base(repository)
        {
        }
    }
}
