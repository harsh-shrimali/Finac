using System.Collections.Generic;
using Finac.Roles.Dto;

namespace Finac.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
