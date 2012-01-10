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
            /* LOADING */
            Maps.Init(); // Load map data
            Items.Init(); // Load items data


            System.Threading.Thread.Sleep(500); // Sleep

            Console.Clear();

            //Console.WriteLine((Items.Random("Key") as DungeonExplorer.game.items.Key).For);
            /*Console.WriteLine(Items.Random("Key").Name);
            Console.WriteLine(Items.Random("Weapon").Name);
            Console.WriteLine(Items.Random("Key").Name);
            Console.WriteLine(Items.Random("Weapon").Name);*/
            Console.WriteLine(Items.Random().Name);

            Console.Title = Config.GameName;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to {0}", Config.GameName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            _p = Player.CreatePlayer(_p);

            Console.Clear();

            Console.Beep(); // BEEP BEEP BEEP
            Console.Beep();
            Console.Beep();

            this.Start(); // Loop till exit
        }

        public bool Start()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Map: ");
            sb.Append(Maps.getMap(_p.Location).Name);
            sb.Append("\r\n\r\n");
            sb.Append(Location(Maps.getMap(_p.Location)));
            Console.WriteLine(sb);

            string[] command = Console.ReadLine().ToLower().Split(' ');

            return (Commands.Handle(_p, command) == false) ? false : Start();
        }

        private string Location(Map location)
        {
            return location.Msg;
        }
    }
}
