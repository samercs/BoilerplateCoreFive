using System.Threading.Tasks;
using Boilerplate.Configuration.Dto;

namespace Boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
