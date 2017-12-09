using System.Threading.Tasks;
using Abp.Application.Services;
using AbpStudy.Authorization.Accounts.Dto;

namespace AbpStudy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
