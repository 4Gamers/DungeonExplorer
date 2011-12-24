using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer2008.game
{
    public enum Race { Dwarf = 1, Elf, Human, Orc, Halfling };

    public static class Config
    {
        public static string GameName = "Dungeon Explorer";
        public static string Version = "0.0.0";
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
