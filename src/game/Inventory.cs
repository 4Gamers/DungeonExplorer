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
        private int Size = 10;

        public bool Full
        {
            get { return (this.Size == _items.Count); }
        }

        public Inventory(Player p)
        {
            this._player = p;
        }

        /*
         * string type = Item type
         * */
        public void GiveRandom(string type)
        {
            if (this.Full || !Enum.IsDefined(typeof(Config.ItemType), type))
                return; // Not exists

            Item i = Items.Random(type);
            _items.Add(i);
        }


        public void Give(Item item)
        {
            if (!this.Full)
                _items.Add(item);
        }

        public void Take(Item item)
        {
            if (!this.Full)
                _items.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Items:\r\n");
            for (int j = 0; j < Size / 5 + ((Size % 5 != 0) ? 1 : 0); j++) // TABLE
            {
                // j * 5 = START INDEX
                // (j+1)*5 = FINISH INDEX
                // LIMIT = LIMIT

                for (int i = j * 5; i < (j + 1) * 5 && i < Size; i++) // Header
                {
                    sb.Append("|");
                    sb.Append(Helper.AlignCenter((i + 1).ToString(), 17));
                }
                sb.Append("|");
                sb.Append("\r\n");

                for (int i = j * 5; i < (j + 1) * 5 && i < Size; i++) // Rows
                {
                    sb.Append("|");
                    if (i < _items.Count)
                        sb.Append(Helper.AlignCenter(_items.ElementAt(i).Name, 17));
                    else
                        sb.Append(Helper.AlignCenter("empty", 17));
                }
                sb.Append("|");
                sb.Append("\r\n\r\n"); // NEW LINE
            }
            return sb.ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
