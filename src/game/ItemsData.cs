using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    [XmlRootAttribute("ItemsData")]
    public class ItemsData
    {
        [XmlArray("Items")]
        [XmlArrayItem("Item", typeof(Item))]
        [XmlArrayItem("Key", typeof(Key))]
        [XmlArrayItem("Weapon", typeof(Weapon))]
        [XmlArrayItem("Chest", typeof(Chest))]
        [XmlArrayItem("Helmet", typeof(Helmet))]
        public List<Item> Items;

        public ItemsData()
        {
            Items = new List<Item>();
        }
    }

}
