using System.Threading.Tasks;
using Abp.Application.Services;
using AbpStudy.Configuration.Dto;

namespace AbpStudy.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}