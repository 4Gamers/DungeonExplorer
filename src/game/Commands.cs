using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer.game
{
    static class Commands
    {
        public static bool Handle(Player p, string[] command)
        {
            switch (command[0]) // Command Handler
            {
                case "move":
                    if (!Commands.Move(p, command[1]))
                        Console.WriteLine("Blocked");
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

        public static bool Move(Player p, string to)
        {
            char where = (char)to.First();

            int mapTo = p.Location;

            switch (where)
            {
                case 'w':
                    mapTo--;
                    break;
                case 'e':
                    mapTo++;
                    break;
                case 'n':
                    mapTo -= 10;
                    break;
                case 's':
                    mapTo += 10;
                    break;
            }

            return p.ChangeMap(mapTo);
        }
    }
}
