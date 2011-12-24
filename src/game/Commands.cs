using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer2008.game
{
    static class Commands
    {
        public static bool Handle(string[] command)
        {
            switch (command[0]) // Command Handler
            {
                case "move":
                    break;
                case "use":
                case "switch":
                case "pull":
                    break;
                case "clear":
                    break;
                case "take":
                case "grab":
                    break;
                case "exit":
                    Console.WriteLine("Are you sure you want to exit? (Y/N)");
                    if (Console.ReadLine() == "Y")
                        return false; // Lets exit
                    break;
                default:
                    // HELP
                    Commands.Help();
                    break;
            }
            return true; // LOOP
        }

        public static void Help()
        {
            Console.WriteLine("Help help help");
        }
    }
}
