using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Finac.Configuration.Dto;

namespace Finac.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FinacAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
