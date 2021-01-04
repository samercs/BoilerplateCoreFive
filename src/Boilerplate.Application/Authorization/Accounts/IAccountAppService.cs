﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Boilerplate.Authorization.Accounts.Dto;

namespace Boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
