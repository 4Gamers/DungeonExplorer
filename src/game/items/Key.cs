using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;

namespace DungeonExplorer.game.items
{
    class Key : Item
    {
        [XmlElement(ElementName = "For")]
        public int For { get; set; }

        public override string Name
        {
            get { return String.Format("Key {0:D2}", For); }
        }


        public Key()
        {
            this.Type = "Key";
        }

        public override void Randomize()
        {
            base.Randomize();
            For = Config.rnd.Next(0, 5);
        }
    }
}
