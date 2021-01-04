using System.Collections.Generic;
using Boilerplate.Roles.Dto;

namespace Boilerplate.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}