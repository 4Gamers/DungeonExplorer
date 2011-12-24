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
            Console.WriteLine("Welcome to {0}", Config.GameName);
            Console.WriteLine();
            Player.CreatePlayer(_p);

            Console.WriteLine();
            Console.WriteLine();
            Console.Beep();
            Console.WriteLine();

            Console.WriteLine();
            this.Start();
        }

        public bool Start()
        {
            Console.WriteLine(Location(/*mapid*/0));
            string[] command = Console.ReadLine().ToLower().Split(' ');

            return (Commands.Handle(command) == false) ? false : Start();
        }

        private string Location(int location)
        {
            return "You find your self in a locked cellar in a dungeon.\nPlease choose your action.\n(you can type HELP for your commands list).";
        }
    }
}
