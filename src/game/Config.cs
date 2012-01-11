using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game
{

    public static class Config
    {
        public static string GameName = "Dungeon Explorer";
        public static string Version = "0.0.0.0?";

        public static Random rnd = new Random();

        public enum Handle { Start = 1, Exit, Error, Suppress };

        public enum Race { Dwarf = 1, Elf, Human, Orc, Halfling };

        public enum Class { Fighter = 1, Wizard, Cleric, Rogue, Ranger };

        public enum ItemType { Item = 1, Key, Weapon, Chest };

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

        public static string Races // Class to string
        {
            get
            {
                string races = "";

                foreach (Race c in Enum.GetValues(typeof(Race)))
                {
                    races += c.ToString() + ",";
                }
                races = races.Substring(0, races.Length - 1);

                return races;
            }
        }

    }
}
