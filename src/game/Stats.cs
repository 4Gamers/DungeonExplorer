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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stats: ");
            sb.Append("\r\n");
            foreach (DictionaryEntry entry in this)
            {
                sb.Append("\t");
                sb.AppendFormat("{0}: {1}", entry.Key, entry.Value);
                sb.Append("\r\n");
            }
            return sb.ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
