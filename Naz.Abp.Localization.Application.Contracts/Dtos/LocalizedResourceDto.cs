using Volo.Abp.Application.Dtos;

namespace Localization.Dtos
{
    public class LocalizedResourceDto : EntityDto<int>
    {
        public string Key { get; set; }
        public string DefaultValue { get; set; }
        public string Resource { get; set; }
        public string CultureName { get; set; }
    }
}
