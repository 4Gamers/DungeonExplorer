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
         *          0-Helmet
         *  1-Armor1         2-Armor2
         *                   3-Weapon
         *      
         * 
         *  4-Shoes          4-Shoes
         */

        private Item[] _equipments = new Item[5] { new Item("Helmet"), new Item("Armor1"), new Item("Armor2"), new Weapon(), new Item("Shoes") };
        private Player _player;

        public Equipment(Player p)
        {
            this._player = p;
        }
    }
}
