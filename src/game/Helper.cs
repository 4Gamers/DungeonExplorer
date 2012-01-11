using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game
{
    static class Helper
    {
        public static string AlignCenter(string text, int width)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
