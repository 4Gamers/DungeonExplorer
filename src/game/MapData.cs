using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer2008.game
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class MapsData
    {
        [XmlElement("Map")]
        public List<Map> Maps { get; set; }

        public MapsData()
        {
            Maps = new List<Map>();
        }
    }

}
