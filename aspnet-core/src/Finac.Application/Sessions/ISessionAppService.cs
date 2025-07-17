using System.Threading.Tasks;
using Abp.Application.Services;
using Finac.Sessions.Dto;

namespace Finac.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
