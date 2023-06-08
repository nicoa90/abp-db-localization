using Microsoft.Extensions.Localization;
using Volo.Abp.Domain.Entities.Auditing;

namespace Localization
{
    public class LocalizedResource : FullAuditedEntity<int>
    {
        public LocalizedResource()
        {

        }
        public LocalizedResource(string key, string defaultValue)
        {
            Key = key;
            DefaultValue = defaultValue;
        }
       
        public string Key { get; set; }
        public string DefaultValue { get; set; }
        public string Resource { get; set; }
        public string CultureName { get; set; }

        public LocalizedString GetLocalizedString(string cultureName)
        {
            return new LocalizedString(Key, DefaultValue);
        }
    }
}
