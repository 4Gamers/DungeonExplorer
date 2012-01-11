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
    static class Maps
    {
        static MapsData MapsData;

        static Maps()
        {
            Console.WriteLine("Loading maps...");
            Load();
        }

        public static void Load()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(MapsData), new XmlRootAttribute("Maps"));
            XmlTextReader textReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DungeonExplorer.data.maps.xml"));
            textReader.Normalization = false;
            MapsData = (MapsData)deserializer.Deserialize(textReader);
            textReader.Close();
            foreach (Map m in MapsData.Maps)
            {
                m.Blocked = m.BlockedMaps.Split(',').Select(n => int.Parse(n)).ToArray();
                m.Initalize();
            }
        }

        public static void Init()
        {
            Console.WriteLine("\tMaps loaded.");
        }

        public static bool MapExists(int loc)
        {
            return (MapsData.Maps.Count > loc);
        }

        public static Map getMap(int loc)
        {
            return MapsData.Maps[loc]; // 0 = Blank
        }
    } 
}
