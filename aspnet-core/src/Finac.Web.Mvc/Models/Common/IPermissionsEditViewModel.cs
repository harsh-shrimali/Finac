using System.Collections.Generic;
using Finac.Roles.Dto;

namespace Finac.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}