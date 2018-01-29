using GoGames.Models;
using GoGames.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGames.Controllers
{
    public class GamesListController : Controller
    {
        // GET: GamesList
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "GameName,GameType,Description,CreationYear")] Game game)
        {
            if (ModelState.IsValid)
            {
                DataRegister.Games.Add(game.GameName, game);
                return RedirectToAction("Details/"+game.GameName);
            }

            return View(game);
        }

        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Edit(string id)
        {
            ViewData["ID"] = id;

            return View();
        }

        [Authorize(Roles = "Admin,Manager")]
        public ActionResult Details(string id)
        {
            Game game = DataRegister.Games[id];

            ViewData["GameName"] = game.GameName;
            ViewData["GameType"] = game.GameType;
            ViewData["Description"] = game.Description;
            ViewData["Years"] = game.CreationYear;

            return View();
        }

        [Authorize(Roles = "Admin")]
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