using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Finac.Controllers;

namespace Finac.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : FinacControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
