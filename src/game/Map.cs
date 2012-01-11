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
        public int Chest { get; set; }
        [XmlIgnore]
        public bool HasChest
        {
            get { return (this.Chest != 0); }
        }

        [XmlElement(ElementName = "Blocked")]
        public string BlockedMaps { get; set; }

        [XmlIgnore]
        public int[] Blocked = new int[0];

        /* Map data */

        private Chest _Chest;



        public void Initalize()
        {
            if (this.Chest != 0)
                _Chest = new Chest(this.Chest);
        }

        public bool From(int map)
        {
            return !(Blocked.Contains(map) || Maps.getMap(map).Blocked.Contains(map)); // False if blocked
        }
    }

}
