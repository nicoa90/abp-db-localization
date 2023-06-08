using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Volo.Abp.Localization;

namespace Localization
{
    public class DatabaseLocalizationResourceContributor : ILocalizationResourceContributor
    {
        private IAppLocalizationRepository _localizationRepository;
        private readonly string _resourceName = null;

        public bool IsDynamic => false;

        public DatabaseLocalizationResourceContributor(string resourceName = null)
        {
            _resourceName = resourceName;
        }

        public void Initialize(LocalizationResourceInitializationContext context)
        {
            _localizationRepository = context.ServiceProvider.GetRequiredService<IAppLocalizationRepository>();
        }

        public LocalizedString GetOrNull(string cultureName, string name)
        {
            return _localizationRepository.GetLocalizedText(cultureName, name, _resourceName).Result;
        }

        public void Fill(string cultureName, Dictionary<string, LocalizedString> dictionary)
        {
            FillAsync(cultureName, dictionary).Wait();
        }

        public async Task FillAsync(string cultureName, Dictionary<string, LocalizedString> dictionary)
        {
            var all = await _localizationRepository.GetList(_resourceName, cultureName);

            foreach (var item in all)
            {
                var value = item.GetLocalizedString(cultureName);
                if (!dictionary.ContainsKey(item.Key))
                {
                    dictionary.Add(item.Key, value);
                }
                else
                {
                    dictionary[item.Key] = value;
                }
            }
        }

        public Task<IEnumerable<string>> GetSupportedCulturesAsync()
        {
            return Task.FromResult(Enumerable.Empty<string>());
        }
    }
}
