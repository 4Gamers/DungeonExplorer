﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game.items
{
    class Weapon : Item
    {
        public int Str = 0;
        public int Dex = 0;

        public Weapon()
        {
            this.Type = "Weapon";
        }

        public override void Randomize()
        {
            base.Randomize();
            Str = Config.rnd.Next(0, 11);
            Dex = Config.rnd.Next(0, 11);
        }
    }
}