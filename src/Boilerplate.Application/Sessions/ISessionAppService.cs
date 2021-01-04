using System.Threading.Tasks;
using Abp.Application.Services;
using Boilerplate.Sessions.Dto;

namespace Boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
