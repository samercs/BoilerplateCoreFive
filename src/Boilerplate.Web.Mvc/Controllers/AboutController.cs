using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Boilerplate.Controllers;

namespace Boilerplate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : BoilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
