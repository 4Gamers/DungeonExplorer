using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Reflection;
using DungeonExplorer.game;

namespace DungeonExplorer.xml
{
    static class Items
    {
        static ItemsData ItemsData;

        static Items()
        {
            Console.WriteLine("Loading Items...");
            Load();
        }

        public static void Load()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(ItemsData), new XmlRootAttribute("Items"));
            XmlTextReader textReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DungeonExplorer.data.items.xml"));
            textReader.Normalization = false;
            ItemsData = (ItemsData)deserializer.Deserialize(textReader);
            textReader.Close();
        }

        public static void Init()
        {
            Console.WriteLine("\tItems loaded.");
        }

        public static Item getItem(int id)
        {
            return ItemsData.Items[id]; // 0 = Blank
        }
    }
}
