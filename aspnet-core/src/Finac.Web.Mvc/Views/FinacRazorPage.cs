using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Finac.Web.Views
{
    public abstract class FinacRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FinacRazorPage()
        {
            LocalizationSourceName = FinacConsts.LocalizationSourceName;
        }
    }
}
