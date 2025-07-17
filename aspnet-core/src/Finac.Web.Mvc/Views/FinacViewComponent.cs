using Abp.AspNetCore.Mvc.ViewComponents;

namespace Finac.Web.Views
{
    public abstract class FinacViewComponent : AbpViewComponent
    {
        protected FinacViewComponent()
        {
            LocalizationSourceName = FinacConsts.LocalizationSourceName;
        }
    }
}
