using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer.game;

namespace DungeonExplorer
{
    class Program
    {
        private static Game game = null;

        private static void Main(string[] args)
        {
            Console.SetWindowSize(100, 50);

            game = new Game(); // PLAY!
        }
    }
}
