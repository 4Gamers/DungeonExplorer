using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    class Inventory
    {
        private Player _player;
        private List<Item> __items = new List<Item>();
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

            Config.ItemType itemType = (Config.ItemType)Enum.Parse(typeof(Config.ItemType), type); // Item type

            Item i;

            switch (itemType) // Randomize
            {
                case Config.ItemType.Weapon:
                    i = new Weapon();
                    (i as Weapon).Randomize();
                    break;
                case Config.ItemType.Key:
                    i = new Key();
                    (i as Key).Randomize();
                    break;
                default:
                    return;
            }

            __items.Add(i);
        }


        public void Give(Item item)
        {
            __items.Add(item);
        }

        public void Take(Item item)
        {
            __items.Remove(item);
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
                    if (__items.Count > i)
                    {
                        Item item = __items[i];
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
