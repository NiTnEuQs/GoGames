using System.Web.Mvc;
using SiteWebMVC.Models.Managers;

namespace SiteWebMVC.Controllers
{
    public class GamesBundlesController : Controller
    {
        
        public ActionResult Add()
        {            
            return View();
        }
        
        public ActionResult Edit(string id)
        {
            ViewData["ID"] = id;
            
            return View();
        }
        
        public ActionResult Details(string id)
        {
            ViewData["ID"] = id;
            
            return View();
        }
        
        public ActionResult Delete(string id)
        {
            foreach (var gameName in DataRegister.Bundles[id].GamesName)
            {
                DataRegister.Games[gameName].BundlesName.Remove(id);
            }
            
            DataRegister.Bundles.Remove(id);

            return RedirectToAction("GamesBundles", "Home");
        }
        
    }
}