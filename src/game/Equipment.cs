using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    class Equipment
    {
        /*
         *              0-Helmet
         *  1-Shoulders        
         *  2-Necklace               3-Trinket         
         *  4-Hand1    5-ChestArmor  6-Hand2
         *             7-Belt
         * 8-Gloves    9-LegArmor    10-Bracers
         *              11-Boots
         */

        private Item[] _equipments = new Item[12] { new Item("Helmet"), new Item("Shoulders"), new Item("Necklace"), new Item("Trinket"), new Item("Hand1"), new Item("ChestArmor"), new Item("Hand2"), new Item("Belt"), new Item("Gloves"), new Item("LegArmor"), new Item("Bracers"), new Item("Boots")};
        private Player _player;



        public Equipment(Player p)
        {
            this._player = p;
        }

        public void Equip(Item item, int slot)
        {
            switch(item.Type)
            {
                case "0": //helmet
                    _equipments[slot] = item;
                    break;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Equipment:\r\n");
            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                        sb.Append("Helmet:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 1:
                        sb.Append("Shoulders:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 2:
                        sb.Append("necklace:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 3:
                        sb.Append("Trinket:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 4:
                        sb.Append("Hand1:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 5:
                        sb.Append("ChestArmor:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 6:
                        sb.Append("Hand2:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 7:
                        sb.Append("Belt:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 8:
                        sb.Append("Gloves:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 9:
                        sb.Append("LegArmor:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 10:
                        sb.Append("Bracers:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    case 11:
                        sb.Append("Boots:");
                        sb.Append(Helper.AlignCenter(_equipments.ElementAt(i).Name, 17));
                        sb.Append("\r\n");
                        break;
                    

                }


            }

            return sb.ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
