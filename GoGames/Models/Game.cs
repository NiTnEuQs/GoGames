using GoGames.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGames.Models
{
    public class Game
    {

        private string gameName;
        private GameType gameType;
        private string description;
        private DateTime creationYear;
        private List<string> bundlesName;

        public Game(string gameName, GameType gameType, string description, DateTime creationYear)
        {
            this.gameName = gameName;
            this.gameType = gameType;
            this.description = description;
            this.creationYear = creationYear;
            bundlesName = new List<string>();
        }

        public void AddGameToBundle(string bundleName)
        {
            DataRegister.Bundles[bundleName].GamesName.Add(gameName);
        }

        public string GameName
        {
            get => gameName;
            set => gameName = value;
        }

        public GameType GameType
        {
            get => gameType;
            set => gameType = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public DateTime CreationYear
        {
            get => creationYear;
            set => creationYear = value;
        }

        public List<string> BundlesName
        {
            get => bundlesName;
            set => bundlesName = value;
        }

        public override string ToString()
        {
            return GameName;
        }

    }
}