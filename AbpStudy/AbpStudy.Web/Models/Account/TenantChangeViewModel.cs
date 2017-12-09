using Abp.AutoMapper;
using AbpStudy.Sessions.Dto;

namespace AbpStudy.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}