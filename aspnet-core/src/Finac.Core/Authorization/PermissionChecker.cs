using Abp.Authorization;
using Finac.Authorization.Roles;
using Finac.Authorization.Users;

namespace Finac.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
