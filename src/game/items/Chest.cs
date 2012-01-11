using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;

namespace DungeonExplorer.game.items
{
    public class Chest : Item
    {
        [XmlElement(ElementName = "Size")]
        public int Length
        {
            get { return _items.Length; }
            set { _items = new Item[value]; this.Randomize(); }
        }

        private Item[] _items;

        public Chest()
            : this(6)
        {
        }

        public Chest(int len)
        {
            if (this.Type == "Item")
                this.Type = "Chest";

            this.Length = len;
        }

        public override void Randomize()
        {
            for (int i = 0; i < _items.Length; i++)
                _items[i] = Items.Random();
            base.Randomize();
        }
    }
}
