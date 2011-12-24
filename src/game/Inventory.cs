using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game
{
    class Inventory
    {
        private Player p;
        private List<Item> items = new List<Item>();

        public Inventory(Player p)
        {
            this.p = p;
        }

        public void Give(Item i)
        {
            items.Add(i);
        }

        public void Take(Item i)
        {
            items.Remove(i);
        }

    }
}
