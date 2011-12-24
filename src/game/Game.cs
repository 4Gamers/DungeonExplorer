using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer.xml;

namespace DungeonExplorer.game
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
            _p = Player.CreatePlayer(_p);

            Console.Clear();

            this.Start(); // Loop till exit
        }

        public bool Start()
        {
            Console.WriteLine("Map: "+Maps.getMap(_p.Location).Name);
            Console.WriteLine(Location(Maps.getMap(_p.Location)));

            string[] command = Console.ReadLine().ToLower().Split(' ');

            return (Commands.Handle(_p, command) == false) ? false : Start();
        }

        private string Location(Map location)
        {
            return location.Msg.ToString();
        }
    }
}
