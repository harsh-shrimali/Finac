using Abp.Application.Services;
using Finac.MultiTenancy.Dto;

namespace Finac.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

