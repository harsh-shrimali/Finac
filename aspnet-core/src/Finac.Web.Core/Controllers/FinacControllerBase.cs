using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Finac.Controllers
{
    public abstract class FinacControllerBase: AbpController
    {
        protected FinacControllerBase()
        {
            LocalizationSourceName = FinacConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
