using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer.game.items
{
    public class Helmet : Item
    {
        public int Def = 0;
        public int Dex = 0;

        public Helmet()
        {
            if (this.Type == "Item")
                this.Type = "Helmet";
        }

        public override void Randomize()
        {
            Def = Config.rnd.Next(0, 11);
            Dex = Config.rnd.Next(0, 11);
            base.Randomize();
        }
    }
}
