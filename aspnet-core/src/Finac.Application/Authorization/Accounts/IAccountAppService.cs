using System.Threading.Tasks;
using Abp.Application.Services;
using Finac.Authorization.Accounts.Dto;

namespace Finac.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
