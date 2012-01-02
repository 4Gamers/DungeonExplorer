using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    [XmlTypeAttribute(AnonymousType = true)]
    public class ItemsData
    {
        [XmlElement("Item")]
        public List<Item> Items { get; set; }

        public ItemsData()
        {
            Items = new List<Item>();
        }
    }

}
