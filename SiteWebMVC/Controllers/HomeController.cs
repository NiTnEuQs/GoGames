using System.Threading.Tasks;
using System.Web.Mvc;

namespace SiteWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GamesList()
        {
            ViewData["Message"] = "Your games list page.";

            return View();
        }

        public ActionResult GamesBundles()
        {
            ViewData["Message"] = "Your games bundle page.";

            return View();
        }
    }
}