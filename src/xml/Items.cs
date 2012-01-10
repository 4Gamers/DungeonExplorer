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

            XmlSerializer deserializer = new XmlSerializer(typeof(ItemsData));
            XmlTextReader textReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DungeonExplorer.data.items.xml"));
            textReader.Normalization = false;
            ItemsData = (ItemsData)deserializer.Deserialize(textReader);
            textReader.Close();
        }

        public static void Init()
        {
            Console.WriteLine("\tItems loaded.");
        }

        // Return item by id
        public static Item getItem(int id)
        {
            return ItemsData.Items[id]; // 0 = Blank
        }

        public static List<Item> ItemsByType(string type)
        {
            return (List<Item>)ItemsData.Items.Where(i => i.Type == type).ToList();
        }

        // Random item
        public static Item Random()
        {
            Item item = Items.getItem(Config.rnd.Next(1, ItemsData.Items.Count)); // Get random item
            item.Randomize();

            return item;
        }

        // Random item from specific type
        public static Item Random(string type)
        {
            List<Item> items = ItemsByType(type);
            
            Item item = items[Config.rnd.Next(0, items.Count)]; // Get random item
            item.Randomize();

            return item;
        }
    }
}
