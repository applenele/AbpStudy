using System.Collections.Generic;
using AbpStudy.Roles.Dto;
using AbpStudy.Users.Dto;

namespace AbpStudy.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}