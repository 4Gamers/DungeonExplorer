using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DungeonExplorer.game.items;

namespace DungeonExplorer.game
{
    static class Commands
    {
        private static List<string> _commands = new List<string>();

        static Commands()
        { 
            // get all public static methods of MyClass type
            MethodInfo[] methodInfos = typeof(Commands).GetMethods(BindingFlags.Public |
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
                    case "take":
                        command += " (slot)";
                        break;
                    case "equip":
                        command += " (item) ";
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
                        return Config.Handle.Suppress;
                    }
                    break;
                case "use":
                case "switch":
                case "pull":

                    // need to add levers and other stuff to pull in the map xml

                    break;
                case "clear":
                    Commands.Clear();
                    break;
                case "take":
                case "grab":
                    int slot;
                    if (int.TryParse(command[1], out slot))
                        if (!Commands.Take(p, slot))
                            if (p.Map.HasChest)
                                Console.WriteLine("Your inventory is full");
                            else
                                Console.WriteLine("No chests in this room");
                    break;
                case "drop":
                    // DROP DA BASS!!
                    break;
                case "open":
                    if (Commands.Open(p))
                        return Config.Handle.Suppress;
                    break;
                case "stats":
                    Commands.Stats(p);
                    break;
                case "inv":
                case "inventory":
                case "showinventory":
                case "showinv":
                case "i":
                    Commands.ShowInventory(p);
                    break;
                case "equipment":
                    Commands.ShowEquipment(p);
                    break;
                /*case "equip":
                    slot = ReadSlot();
                    Commands.EquipItem(p, slot);
                    break;*/
                case "exit":
                    Console.WriteLine("Are you sure you want to exit? (Y/N)");
                    if (char.ToUpper(Console.ReadLine()[0]) == 'Y')
                        return Config.Handle.Exit; // Lets exit
                    break;
                case "look":
                case "observe":
                case "examine":
                        Console.WriteLine("YOUR MOM IN A PITA");


                    // PRINTS LOCATION MASSAGE - MAYBE SOME ROOMS WILL HAVE DEEPER EXAMINE MSG
                    // ADD SPOT SKILL THAT IF YOU HAVE ENOUGH YOU CAN SEE MORE STUFF IN A ROOM
                    break;
                default:
                    // HELP
                    Commands.Help();
                    break;
            }
            return Config.Handle.Start; // LOOP
        }

        public static int ReadSlot()
        {
            Console.Write("\nPlease enter which slot to equip: ");
            int slot = int.Parse(Console.ReadLine());
            while ((slot > 11) || (slot <0))
            {
                Console.Write("\nPlease enter an available slot: ");
                slot = int.Parse(Console.ReadLine());
            }
            return slot;
        }

        public static void Help()
        {
            Console.WriteLine();
            foreach (string cmd in Commands._commands)
                Console.WriteLine(cmd);
            Console.WriteLine();
        }

        public static void Clear()
        {
            Console.Clear();
        }

        public static void ShowInventory(Player p)
        {
            p.Inv.Print();
        }

        public static void ShowEquipment(Player p)
        {
            p.Equip.Print();
        }

        public static void Stats(Player p)
        {
            p.Stats.Print();
        }


        /*public static string EquipItem(Player p, int slot)
        {

            if (slot == 1212)
            {
                Console.WriteLine("This slot is empty.");
            }



            Config.ItemType t = (Config.ItemType)Enum.Parse(typeof(Config.ItemType), );

            string type = Config.ItemType.

            return ;
        }*/

        public static bool Open(Player p)
        {
            Map map = p.Map;
            if (map.HasChest)
                Console.WriteLine(map.Chest.ToString());
            return (map.HasChest);
        }

        public static bool Take(Player p, int slot)
        {
            if (!p.Map.HasChest || p.Inv.Full)
                return false;
            Chest chest = p.Map.Chest;
            Item i = chest.ItemAt(slot);
            if (i != null)
            {
                p.Inv.Give(i);
                chest.Remove(slot);
                return true;
            }
            return false;
        }

        public static int Move(Player p, string[] cmd)
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
