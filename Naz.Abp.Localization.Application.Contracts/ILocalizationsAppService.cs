using Localization.Dtos;
using Volo.Abp.Application.Services;

namespace Localization
{
    public interface ILocalizationsAppService : ICrudAppService<LocalizedResourceDto, int, LocalizedResourceRequest>
    {
    }
}
