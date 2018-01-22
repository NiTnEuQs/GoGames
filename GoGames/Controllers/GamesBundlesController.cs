using GoGames.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGames.Controllers
{
    public class GamesBundlesController : Controller
    {
        // GET: GamesBundles
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