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
         *  9-Shoulders        
         *  1-Necklace               11-Trinket         
         *  2-Hand1    4-ChestArmor  3-Hand2
         *              10-Belt
         * 5-Gloves    6-LegArmor    7-Bracers
         *              8-Shoes
         */

        private Item[] _equipments = new Item[13] { new Item("Helmet"), new Item("Necklace"), new Item("Trinket"), new Weapon(), new Item("Hand1"), new Item("Hand2"), new Item("ChestArmor"), new Item("Gloves"), new Item("LegArmor"), new Item("Bracers"), new Item("Shoes"), new Item("Shoulders"), new Item("Belt") };
        private Player _player;

        public Equipment(Player p)
        {
            this._player = p;
        }
    }
}
