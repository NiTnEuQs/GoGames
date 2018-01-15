using System.Web.Mvc;
using SiteWebMVC.Models.Managers;

namespace SiteWebMVC.Controllers
{
    public class GamesListController : Controller
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
            foreach (var bundleName in DataRegister.Games[id].BundlesName)
            {
                DataRegister.Bundles[bundleName].GamesName.Remove(id);
            }
            
            DataRegister.Games.Remove(id);

            return RedirectToAction("GamesList", "Home");
        }
        
    }
}