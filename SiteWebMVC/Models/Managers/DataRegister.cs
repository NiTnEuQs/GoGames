using System.Collections.Generic;

namespace SiteWebMVC.Models.Managers
{
    public class DataRegister
    {
        
        // Attributes
        
        private static Dictionary<string, Game> games = new Dictionary<string, Game>();
        private static Dictionary<string, Bundle> bundles = new Dictionary<string, Bundle>();

        // Properties
        
        public static Dictionary<string, Game> Games
        {
            get => games;
            set => games = value;
        }
        
        public static Dictionary<string, Bundle> Bundles
        {
            get => bundles;
            set => bundles = value;
        }
        
    }
}