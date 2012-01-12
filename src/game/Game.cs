using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonExplorer.xml;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    class Game
    {
        private Player _p = null;

        public Game()
        {
            /* LOADING */
            Items.Init(); // Load items data
            Maps.Init(); // Load map data

            System.Threading.Thread.Sleep(500); // Sleep

            Console.Clear();

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

            this.Start(Config.Handle.Start); // Loop till exit
        }

        public bool Start(Config.Handle status)
        {
            StringBuilder sb = new StringBuilder();
            if (status != Config.Handle.Suppress)
            {
                sb.Append("Map: ");
                sb.Append(Maps.getMap(_p.Location).Name);
                sb.Append("\r\n");
                sb.Append("\r\n");
                sb.Append(this.Location(Maps.getMap(_p.Location)));
            }
            Console.WriteLine(sb);

            string[] command = Console.ReadLine().ToLower().Split(' ');

            Config.Handle work = Commands.Handle(_p, command);
            return (work == Config.Handle.Exit) ? false : Start(work);


        }

        private string Location(Map location)
        {
            return location.Msg;
        }
    }
}
