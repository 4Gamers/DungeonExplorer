using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer.game
{
    public class Animal : Monster
    {
        public int Health = 0;
        public int Str = 0, Def = 0;

        public Animal()
        {
            if (this.Type == "Monster")
                this.Type = "Animal";
        }

        public override void Randomize()
        {
            Def = Config.rnd.Next(0, 11);
            Health = Config.rnd.Next(0, 11);
            Health *= 100;
            base.Randomize();
        }
    }
}
