using System.Collections.Generic;
using Boilerplate.Roles.Dto;

namespace Boilerplate.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
