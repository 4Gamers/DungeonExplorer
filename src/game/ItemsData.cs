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
        [XmlArrayItem("Keys", typeof(Key))]
        [XmlArrayItem("Weapons", typeof(Weapon))]     
        public List<Item> Items { get; set; }

        public ItemsData()
        {
            Items = new List<Item>();
        }
    }

}
