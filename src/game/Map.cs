using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer.game
{
    public class Map
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Msg")]
        public string Msg { get; set; }

        public bool From(int map)
        {
            return true; // False if blocked
        }
    }

}
