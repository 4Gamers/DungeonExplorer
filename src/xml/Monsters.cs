using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;
using DungeonExplorer.game;
using DungeonExplorer.game.items;

namespace DungeonExplorer.xml
{
    static class Monsters
    {
        static MonstersData MonstersData;

        static Monsters()
        {
            Console.WriteLine("Loading Monsters...");
            Load();
        }

        public static void Load()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(MonstersData));
            XmlTextReader textReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DungeonExplorer.data.monsters.xml"));
            textReader.Normalization = false;
            MonstersData = (MonstersData)deserializer.Deserialize(textReader);
            textReader.Close();
        }

        public static void Init()
        {
            Console.WriteLine("\tMonsters loaded.");
        }

        public static Monster getMonster(int id)
        {
            return MonstersData.Monsters[id]; // 0 = Blank
        }

        // Random monster
        public static Monster Random(int playerLvl)
        {
            Monster monster = Monsters.getMonster(Config.rnd.Next(playerLvl-1, playerLvl+1));
            monster.Randomize();

            return monster;
        }
    }
}
