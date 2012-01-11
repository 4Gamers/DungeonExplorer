using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    public class Map
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Fight")]
        public bool Fight { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Msg")]
        public string Msg { get; set; }

        [XmlElement(ElementName = "Chest")]
        public int ChestSize { get; set; }

        [XmlIgnore]
        public Chest Chest;

        [XmlIgnore]
        public bool HasChest
        {
            get { return (this.ChestSize != 0); }
        }

        [XmlElement(ElementName = "Blocked")]
        public string BlockedMaps { get; set; }

        [XmlIgnore]
        public int[] Blocked = new int[0];



        public void Initalize()
        {
            if (this.ChestSize != 0)
                Chest = new Chest(this.ChestSize);
        }

        public bool From(int map)
        {
            return !(Blocked.Contains(map) || Maps.getMap(map).Blocked.Contains(map)); // False if blocked
        }
    }

}
