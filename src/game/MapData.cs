using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer.game
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class MapsData
    {
        [XmlElement("Map")]
        public List<Map> Maps;

        public MapsData()
        {
            Maps = new List<Map>();
        }
    }

}
