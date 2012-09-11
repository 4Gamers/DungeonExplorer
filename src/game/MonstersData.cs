using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    [XmlRootAttribute("MonstersData")]
    public class MonstersData
    {
        [XmlArray("Monsters")]
        [XmlArrayItem("Animal", typeof(Animal))]
        [XmlArrayItem("Human", typeof(Human))]
        public List<Monster> Monsters;

        public MonstersData()
        {
            Monsters = new List<Monster>();
        }
    }
}
