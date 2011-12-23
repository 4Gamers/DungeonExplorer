using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer2008.game;

namespace DungeonExplorer2008
{
    class Program
    {
        private static Player player1 = null;

        private static void Main(string[] args)
        {
            Console.Title = Config.GameName;
            Console.WriteLine();
            Console.WriteLine("Welcome to {0}", Config.GameName);
            Console.WriteLine();
            Player.CreatePlayer(player1);
        }
    }
}
