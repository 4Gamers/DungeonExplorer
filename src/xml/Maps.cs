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
            XmlSerializer deserializer = new XmlSerializer(typeof(MapsData), new XmlRootAttribute("Maps"));
            XmlTextReader textReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("DungeonExplorer.maps.xml"));
            textReader.Normalization = false;
            MapsData = (MapsData)deserializer.Deserialize(textReader);
            textReader.Close();
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
