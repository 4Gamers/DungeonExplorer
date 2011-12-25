using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;

namespace DungeonExplorer.game
{
    class Item
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Name")]
        public virtual string Name { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }

        public Item()
        {
            this.Type = "Item";
        }

        public virtual void Randomize()
        {
        }
    }
}
