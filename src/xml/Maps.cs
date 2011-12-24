using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using DungeonExplorer.game;

namespace DungeonExplorer.xml
{
    static class Maps
    {
        static MapsData MapsData;

        static Maps()
        {
            var deserializer = new XmlSerializer(typeof(MapsData), new XmlRootAttribute("Maps"));
            TextReader textReader = new StreamReader(global::DungeonExplorer.Properties.Resources.maps);
            MapsData = (MapsData)deserializer.Deserialize(textReader);
            textReader.Close();
        }

        public static Map getMap(int loc)
        {
            return MapsData.Maps[loc-1]; // 1 = 0
        }
    }
}
