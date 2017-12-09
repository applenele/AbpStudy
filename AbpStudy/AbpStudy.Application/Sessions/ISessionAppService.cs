using System.Threading.Tasks;
using Abp.Application.Services;
using AbpStudy.Sessions.Dto;

namespace AbpStudy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
