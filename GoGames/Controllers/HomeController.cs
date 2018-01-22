using GoGames.Models;
using GoGames.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGames.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GamesList()
        {
            return View();
        }

        public ActionResult GamesBundles()
        {
            return View();
        }

        public ActionResult AddValues()
        {
            DataRegister.Games.Add("FIFA 18",
                new Game("FIFA 18", GameType.Sport, "Simulation de football", new DateTime(2017, 9, 14)));
            DataRegister.Games.Add("Call of Duty - MW II",
                new Game("Call of Duty - MW II", GameType.FPS, "Simulation de guerre", new DateTime(2017, 10, 25)));
            DataRegister.Games.Add("Pokémon Version Bleue",
                new Game("Pokémon Version Bleue", GameType.RPG,
                    "Capturer des créatures et faites-les combattre contre d'autres", new DateTime(1994, 1, 1)));
            DataRegister.Games.Add("Pokémon Version Rouge",
                new Game("Pokémon Version Rouge", GameType.RPG,
                    "Capturer des créatures et faites-les combattre contre d'autres", new DateTime(1994, 1, 1)));
            DataRegister.Games.Add("Super Mario Bros",
                new Game("Super Mario Bros", GameType.Plateforme,
                    "Sauvez la princesse Peach des mains du méchant Bowser", new DateTime(1991, 1, 1)));

            DataRegister.Bundles.Add("Pokémon Bundle", new Bundle("Pokémon Bundle", GameType.RPG,
                "Toutes les versions de la série des jeux Pokémon", new DateTime(2017, 12, 25),
                new List<string> { "Pokémon Version Bleue", "Pokémon Version Rouge" }));
            DataRegister.Bundles.Add("Call of Duty Bundle", new Bundle("Call of Duty Bundle", GameType.FPS,
                "Toutes les versions de la série des jeux Call of Duty", new DateTime(2018, 1, 4),
                new List<string> { "Call of Duty - MW II" }));

            return RedirectToAction("Index", "Home");
        }

    }
}