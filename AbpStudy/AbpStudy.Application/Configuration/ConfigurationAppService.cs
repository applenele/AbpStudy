using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpStudy.Configuration.Dto;

namespace AbpStudy.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpStudyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
