using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DungeonExplorer.game
{
    public class Map
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Msg { get; set; }

        public int[] Blocked { get; set; }

        public bool From(int map)
        {
            return Blocked.Contains(map); // False if blocked
        }
    }

}
