using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    public class Monster
    {
        [XmlElement(ElementName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "LevelMax")]
        public int LevelMax { get; set; }

        [XmlElement(ElementName = "LevelMin")]
        public int LevelMin { get; set; }

        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }


        public Monster() : this (null)
        {
        }

        public Monster(string name)
        {
            this.Name = name;
            this.Type = "Monster";
        }

        public virtual void Randomize()
        {
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
