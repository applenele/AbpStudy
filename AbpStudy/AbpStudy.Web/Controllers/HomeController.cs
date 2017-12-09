using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AbpStudy.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpStudyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}