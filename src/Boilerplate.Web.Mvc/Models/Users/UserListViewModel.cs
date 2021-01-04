using System.Collections.Generic;
using Boilerplate.Roles.Dto;

namespace Boilerplate.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
