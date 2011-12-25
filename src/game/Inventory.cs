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
            for (int j = 0; j < LIMIT/5; j++) // TABLE
            {
                // j * 5 = START INDEX
                // (j+1)*5 = FINISH INDEX
                // LIMIT = LIMIT

                Console.Write("Slot:");
                Console.Write("\t");
                for (int i = j * 5; i < (j + 1) * 5 && i < LIMIT; i++) // Header
                {
                    Console.Write(i + 1);
                    Console.Write("\t");
                }
                Console.WriteLine();

                Console.Write("\t");
                for (int i = j * 5; i < (j + 1) * 5 && i < LIMIT; i++) // Rows
                {
                    if (items.Count > i)
                    {
                        Item item = items[i];
                        Console.Write(item.Name);
                    }
                    else
                        Console.Write("empty");
                    Console.Write("\t");
                }
                Console.WriteLine("\r\n"); // NEW LINE
            }
        }
    }
}
