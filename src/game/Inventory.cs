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
        private const int LIMIT = 10;

        public Inventory(Player p)
        {
            this.p = p;
        }

        public void Give(Item item)
        {
            items.Add(item);
        }

        public void Take(Item item)
        {
            items.Remove(item);
        }

        public void Print()
        {
            int j; // just for the slot 1:
            for (int i = 0; i < LIMIT; i++)
            {
                j = i+1;
                Console.Write("slot "+j+": ");
                if (items.Count > i)
                {
                    Item item = items[i];
                    Console.WriteLine(item.Name);
                }
                else
                    Console.WriteLine("empty");
            }
            Console.WriteLine("\n");
        }
    }
}
