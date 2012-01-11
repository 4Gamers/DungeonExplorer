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
        public int Size
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

            this.Size = len;
        }

        public Item ItemAt(int pos)
        {
            if (pos <= this.Size)
                return _items[pos - 1]; // 1 = 0
            return null;
        }

        public void Remove(int pos)
        {
            if (pos <= this.Size)
             _items[pos - 1] = null;
        }

        public override void Randomize()
        {
            for (int i = 0; i < _items.Length; i++)
                _items[i] = Items.Random();
            base.Randomize();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Items:\r\n");  
            for (int j = 0; j < this._items.Length / 5 + ((this._items.Length % 5 != 0) ? 1 : 0); j++) // TABLE
            {
                // j * 5 = START INDEX
                // (j+1)*5 = FINISH INDEX
                // LIMIT = LIMIT
                for (int i = j * 5; i < (j + 1) * 5 && i < this._items.Length; i++) // Header
                {
                    sb.Append("|");
                    sb.Append(Helper.AlignCenter((i + 1).ToString(), 17));
                }
                sb.Append("|");
                sb.Append("\r\n");

                for (int i = j * 5; i < (j + 1) * 5 && i < this._items.Length; i++) // Rows
                {
                    sb.Append("|");
                        Item item = _items[i];
                    if (item != null)
                        sb.Append(Helper.AlignCenter(item.Name, 17));
                    else
                        sb.Append(Helper.AlignCenter("empty", 17));
                }
                sb.Append("|");
                sb.Append("\r\n\r\n"); // NEW LINE
            }
            return sb.ToString();
        }
    }
}
