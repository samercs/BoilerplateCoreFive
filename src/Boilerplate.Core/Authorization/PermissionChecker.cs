using Abp.Authorization;
using Boilerplate.Authorization.Roles;
using Boilerplate.Authorization.Users;

namespace Boilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
