using System.Web.Mvc;

namespace SiteWebMVC.Controllers
{
    public class ReminderController : Controller
    {
        public ActionResult Edit(int id)
        {
            ViewData["ID"] = id;
            
            return View();
        }
        
        public ActionResult Details(int id)
        {
            ViewData["ID"] = id;
            
            return View();
        }
        
        public ActionResult Delete(int id)
        {
            ViewData["ID"] = id;
            
            return View();
        }
    }
}