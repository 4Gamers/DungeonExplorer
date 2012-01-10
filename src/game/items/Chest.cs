using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer.xml;

namespace DungeonExplorer.game.items
{
    class Chest : Item
    {
        private Item[] _items;

        public Chest()
            : this(6)
        {
        }

        public Chest(int len)
        {
            _items = new Item[len];
        }

        public override void Randomize()
        {
            for (int i = 0; i < _items.Length; i++)
                _items[i] = Items.Random();
            base.Randomize();
        }
    }
}
