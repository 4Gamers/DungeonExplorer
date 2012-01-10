using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    public class Item
    {
        [XmlElementAttribute(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElementAttribute(ElementName = "Name")]
        public virtual string Name { get; set; }

        [XmlElementAttribute(ElementName = "Type")]
        public string Type { get; set; }

        [XmlIgnore]
        public Config.ItemType ItemType
        {
            get
            {
                return (Config.ItemType)Enum.Parse(typeof(Config.ItemType), this.Type); // Item type
            }
        }

        public Item()
        {
            this.Type = "Item";
        }

        public Item(string name) : this()
        {
            this.Name = name;
        }

        public virtual void Randomize()
        {
        }
    }
}
