using System.Web.Mvc;

namespace AbpStudy.Web.Controllers
{
    public class AboutController : AbpStudyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}