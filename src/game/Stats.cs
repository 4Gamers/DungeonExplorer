using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game
{
    class Stats : Hashtable
    {
        public object Get(string key)
        {
            return this[key];
        }
    }
}
