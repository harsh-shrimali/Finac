﻿using System.Collections.Generic;
using Finac.Roles.Dto;

namespace Finac.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
