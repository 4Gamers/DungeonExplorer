using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DungeonExplorer.game.items;
using DungeonExplorer.xml;

namespace DungeonExplorer.game
{
    class Inventory
    {
        private Player _player;
        private List<Item> _items = new List<Item>();
        private const int LIMIT = 10;

        public Inventory(Player p)
        {
            this._player = p;
        }

        /*
         * string type = Item type
         * */
        public void GiveRandom(string type)
        {
            if (!Enum.IsDefined(typeof(Config.ItemType), type))
                return; // Not exists

            Item i = Items.Random(type);
            _items.Add(i);
        }


        public void Give(Item item)
        {
            _items.Add(item);
        }

        public void Take(Item item)
        {
            _items.Remove(item);
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
                    if (_items.Count > i)
                    {
                        Item item = _items[i];
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
