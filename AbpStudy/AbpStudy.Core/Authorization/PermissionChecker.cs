using Abp.Authorization;
using AbpStudy.Authorization.Roles;
using AbpStudy.Authorization.Users;

namespace AbpStudy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
