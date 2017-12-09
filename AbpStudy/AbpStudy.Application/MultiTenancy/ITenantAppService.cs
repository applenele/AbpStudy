using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpStudy.MultiTenancy.Dto;

namespace AbpStudy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
