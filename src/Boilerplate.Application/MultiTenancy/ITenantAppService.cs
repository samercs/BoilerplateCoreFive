using Abp.Application.Services;
using Boilerplate.MultiTenancy.Dto;

namespace Boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

