using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;

namespace DungeonExplorer.game.items
{
    class Key : Item
    {
        [XmlElement(ElementName = "For")]
        public int For { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
    }
}
