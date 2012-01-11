using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DungeonExplorer.game
{
    static class Commands
    {
        private static List<string> _commands = new List<string>();

        static Commands()
        { 
            // get all public static methods of MyClass type
            MethodInfo[] methodInfos = typeof(Commands).GetMethods(BindingFlags.NonPublic |
                                                                  BindingFlags.Static).Where(x => x.Name != "Handle" && x.Name != "Commands").ToArray();

            // Custom help
            foreach (MethodInfo methodInfo in methodInfos)
            {
                string command = methodInfo.Name.ToLower();

                switch (command)
                {
                    case "move":
                        command += " (n/s/w/e)";
                        break;
                }

                _commands.Add(command);
                
            }

        }

        public static Config.Handle Handle(Player p, string[] command)
        {
            switch (command[0]) // Command Handler
            {
                case "move":
                    if (Commands.Move(p, command) == 0)
                    {
                        Console.WriteLine("This way is blocked, try going another way.");
                        return Config.Handle.Supress;
                    }
                    break;
                case "use":
                case "switch":
                case "pull":

                    // need to add levers and other stuff to pull in the map xml

                    break;
                case "clear":
                    Clear();
                    break;
                case "take":
                case "grab":
                    break;
                case "open":
                    break;
                case "inv":
                case "inventory":
                case "showinventory":
                case "showinv":
                case "i":
                    Commands.ShowInventory(p);
                    break;
                case "exit":
                    Console.WriteLine("Are you sure you want to exit? (Y/N)");
                    if (char.ToUpper(Console.ReadLine()[0]) == 'Y')
                        return Config.Handle.Exit; // Lets exit
                    break;
                default:
                    // HELP
                    Commands.Help();
                    break;
            }
            return Config.Handle.Start; // LOOP
        }

        private static void Help()
        {
            Console.WriteLine();
            foreach (string cmd in Commands._commands)
                Console.WriteLine(cmd);
            Console.WriteLine();
        }

        private static void Clear()
        {
            Console.Clear();
        }

        private static void ShowInventory(Player p)
        {
            p.Inv.Print();
        }

        private static int Move(Player p, string[] cmd)
        {
            char where;

            if (cmd.Length > 1)
                where = (char)cmd[1].First();
            else
                where = '?';

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
                default:
                    Console.WriteLine("Type: move n/e/s/w");
                    return -1;
            }
            return (p.ChangeMap(mapTo) == true) ? 1 : 0;
        }
    }
}
