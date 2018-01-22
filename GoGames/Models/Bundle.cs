using GoGames.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGames.Models
{
    public class Bundle : List<Game>
    {

        private string bundleName;
        private GameType bundleType;
        private string description;
        private DateTime creationDate;
        private List<string> gamesName;

        public Bundle(string bundleName, GameType bundleType, string description, DateTime creationDate, List<string> gamesName)
        {
            this.bundleName = bundleName;
            this.bundleType = bundleType;
            this.description = description;
            this.creationDate = creationDate;
            this.gamesName = gamesName;

            foreach (var gameName in gamesName)
            {
                AddGameToBundle(gameName);
            }
        }

        public void AddGameToBundle(string gameName)
        {
            DataRegister.Games[gameName].BundlesName.Add(bundleName);
        }

        public string BundleName
        {
            get => bundleName;
            set => bundleName = value;
        }

        public GameType GameType
        {
            get => bundleType;
            set => bundleType = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public DateTime CreationDate
        {
            get => creationDate;
            set => creationDate = value;
        }

        public List<string> GamesName
        {
            get => gamesName;
            set => gamesName = value;
        }

        public override string ToString()
        {
            return BundleName;
        }

    }
}