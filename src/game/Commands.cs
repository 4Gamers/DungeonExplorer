using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DungeonExplorer.game
{
    static class Commands
    {
        public static bool Handle(Player p, string[] command)
        {
            switch (command[0]) // Command Handler
            {
                case "move":
                    if (!Commands.Move(p, command))
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
            // get all public static methods of MyClass type
            MethodInfo[] methodInfos = typeof(Commands).GetMethods(BindingFlags.Public |
                                                                  BindingFlags.Static).Where(x => x.Name != "Handle").ToArray();
            // sort methods by name
            /*Array.Sort(methodInfos,
                    delegate(MethodInfo methodInfo1, MethodInfo methodInfo2)
                    { return methodInfo1.Name.CompareTo(methodInfo2.Name); });*/

            // write method names
            Console.WriteLine();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                    Console.WriteLine(methodInfo.Name.ToLower());
            }
            Console.WriteLine();
        }

        public static bool Move(Player p, string[] cmd)
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
                    return false;
            }

            return p.ChangeMap(mapTo);
        }
    }
}
