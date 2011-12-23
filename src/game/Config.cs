using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer2008.game
{
    public enum Class { Dwarf = 1, Elf, Human, Orc, Halfling };

    public static class Config
    {
        public static string GameName = "Dungeon Explorer";
        public static string Version = "0.0.0";
        public static string Classes
        {
            get
            {
                string classes = "";

                foreach (Class c in Enum.GetValues(typeof(Class)))
                {
                    classes += c.ToString() + ",";
                }
                classes = classes.Substring(0, classes.Length - 1);

                return classes;
            }
        }
    }
}
