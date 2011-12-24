using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer2008.game
{
    class Game
    {
        private Player _p = null;

        public Game()
        {
            Console.Title = Config.GameName;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to {0}", Config.GameName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Player.CreatePlayer(_p);

            Console.Clear();

            Console.WriteLine();
            this.Start(); // Loop till exit
        }

        public bool Start()
        {
            Console.WriteLine(Location(_p.Location));
            string[] command = Console.ReadLine().ToLower().Split(' ');

            return (Commands.Handle(command) == false) ? false : Start();
        }

        private string Location(int location)
        {
            return "You find your self in a locked cellar in a dungeon.\nPlease choose your action.\n(you can type HELP for your commands list).";
        }
    }
}
