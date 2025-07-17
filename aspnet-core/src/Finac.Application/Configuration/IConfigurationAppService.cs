using System.Threading.Tasks;
using Finac.Configuration.Dto;

namespace Finac.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
