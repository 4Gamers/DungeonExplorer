using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            double heroHealth, monsterHealth, heroDamage, monsterDamage = 0, evade, monsterEvade, potionReg = 5, numOfPots = 0, critChance, a;
            int weaponCC, weaponCD, weaponBD, ii = 0, room = 22, i = 0, door, door1 = 0, door2 = 0, door3 = 0, door4 = 0, door5 = 0, sdoor6 = 0, sdoor7 = 0, door0 = 0, monster = 0, weaponPlus;
            int key1 = 0, key0 = 0, lever2 = 0, lever3 = 0, gold = 1765, silver = 52, chopper = 7, chest = 0, numberOfItems, item2, weaponLvl, playerLvl = 1, monsterLvl, iii;
            int con = 0, str = 0, wis = 0, intel = 0, dex = 0, cha = 0, add, spendingPoints = 20, j = 1, k = 1, i2 = 0, lever1 = 0, lever12 = 0;
            int chest32 = 1, chest18 = 1, chest46 = 1, chest56 = 1, chest55 = 1, chest89 = 1, chest84 = 1, numItems;
            int lenginv1 = 0, lenginv2 = 0, lenginv3 = 0, lenginv4 = 0, lenginv5 = 0, lenginv6 = 0, lenginv7 = 0, lenginv8 = 0, lenginv9 = 0, lenginv10 = 0;
            string item, answer, itemType, weaponType, prefix, suffix, race;
            String inv1 = "empty", inv2 = "empty", inv3 = "empty", inv4 = "empty", inv5 = "empty", inv6 = "empty", inv7 = "empty", inv8 = "empty", inv9 = "empty", inv10 = "empty";
            string actingOpt, weapon, playerName, movment, yesno;

            

            //weaponCC - Weapon Crit Chance
            //weaponCD - Weapon Crit Damage
            //weaponBD - Weapon Base Damage
            //a is used for monster level randoming
            //ii is used to finish weapon choosing switch
            //monster - if monster = 1 there is a fight.
            //iii - prefix or suffix

//            inv1 = "empty", inv2 = "empty", inv3 = "empty", inv4 = "empty", inv5 = "empty", inv6 = "empty", inv7 = "empty", inv8 = "empty", inv9 = "empty", inv10 = "empty";

            string[] inventory1 = new string[10] { inv1, inv2, inv3, inv4, inv5, inv6, inv7, inv8, inv9, inv10 };
            int[] invAmount = new int[10] { lenginv1, lenginv2, lenginv3, lenginv4, lenginv5, lenginv6, lenginv7, lenginv8, lenginv9, lenginv10 };

            //inventory 1 is the string array for items
            //invAmount is the int array for amount of items - what is the amount that you have of each item.

            
            

            /*Console.WriteLine("Welcome to *Game Name*");
            Console.Write("\nPlease Type your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("\nWell, hello "+playerName+ "!");
            System.Threading.Thread.Sleep(1000);
            
            Console.Write("What race were you born into?");
            Console.WriteLine("Dwarf, Elf, Human, Orc or Halfling");
            race = Console.ReadLine();

            race = race.ToLower();
            
            switch (race)
            {
                case "dwarf":
                    con = 12;
                    str = 10;
                    wis = 10;
                    dex = 10;
                    intel = 10;
                    cha = 8;                   
                    break;

                case "elf":
                    con = 8;
                    str = 10;
                    wis = 10;
                    dex = 12;
                    intel = 10;
                    cha = 10;
                    break;

                case "human":
                    con = 10;
                    str = 10;
                    wis = 10;
                    dex = 10;
                    intel = 10;
                    cha = 10;
                    break;

                case "orc":
                    con = 10;
                    str = 14;
                    wis = 10;
                    dex = 10;
                    intel = 10;
                    cha = 6;
                    break;

                case "halfling":
                    con = 8;
                    str = 10;
                    wis = 10;
                    dex = 12;
                    intel = 10;
                    cha = 10;
                    break;        
            }

            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Constitution?");
            Console.Write("Con: ");
            add = int.Parse(Console.ReadLine());
            con += add;
            spendingPoints -= add;
            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Strength?");
            Console.Write("Str: ");
            add = int.Parse(Console.ReadLine());
            str += add;
            spendingPoints -= add;
            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Dexterity?");
            Console.Write("Dex: ");
            add = int.Parse(Console.ReadLine());
            dex += add;
            spendingPoints -= add;
            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Intelligence?");
            Console.Write("Int: ");
            add = int.Parse(Console.ReadLine());
            intel += add;
            spendingPoints -= add;
            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Wisdom?");
            Console.Write("Wis: ");
            add = int.Parse(Console.ReadLine());
            wis += add;
            spendingPoints -= add;
            Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
            Console.WriteLine("How many would you put in Charisma?");
            Console.Write("Cha: ");
            add = int.Parse(Console.ReadLine());
            cha += add;
            spendingPoints -= add;

            while (spendingPoints != 0)
            {
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Constitution?");
                Console.Write("Con: ");
                add = int.Parse(Console.ReadLine());
                con += add;
                spendingPoints -= add;
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Strength?");
                Console.Write("Str: ");
                add = int.Parse(Console.ReadLine());
                str += add;
                spendingPoints -= add;
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Dexterity?");
                Console.Write("Dex: ");
                add = int.Parse(Console.ReadLine());
                dex += add;
                spendingPoints -= add;
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Intelligence?");
                Console.Write("Int: ");
                add = int.Parse(Console.ReadLine());
                intel += add;
                spendingPoints -= add;
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Wisdom?");
                Console.Write("Wis: ");
                add = int.Parse(Console.ReadLine());
                wis += add;
                spendingPoints -= add;
                Console.WriteLine("You have " + spendingPoints + " points to put in your stats");
                Console.WriteLine("How many would you put in Charisma?");
                Console.Write("Cha: ");
                add = int.Parse(Console.ReadLine());
                cha += add;
                spendingPoints -= add;
            
            }*/
            Console.WriteLine("You find your self in a locked cellar in a dungeon.\nPlease choose your action.\n(you can type HELP for your commands list).");
            while (numOfPots > -1)
            {
                actingOpt = Console.ReadLine();
                movment = actingOpt;
                actingOpt = actingOpt.ToLower();
                switch (actingOpt)
                {
                    case "Look":
                    case "LOOK":
                    case "look":
                        Console.WriteLine(Look(room, movment));
                        break;

                    case "use":
                    case "switch":
                    case "pull":

                        switch (room)
                        { 
                            case 1:
                                if (lever1 == 0)
                                {
                                    Console.WriteLine("You pull the lever, you hear a mechanism opens up to the south-east");
                                    door2 = 1;
                                    lever1 = 1;
                                }
                                else
                                {
                                    Console.WriteLine("This lever is already pulled.");
                                }
                            break;

                            case 79:
                            if (lever12 == 0)
                            {
                                Console.WriteLine("You pull the lever, you hear a mechanism opens up to the north");
                                door3 = 1;
                                lever12 = 1;
                            }
                            else
                            {
                                Console.WriteLine("This lever is already pulled.");
                            }


                            break;
                        }

                        break;

                    case "north":
                    case "n":
                    case "NORTH":
                    case "North":
                    case "N":
                    case "west":
                    case "WEST":
                    case "W":
                    case "w":
                    case "West":
                    case "south":
                    case "s":
                    case "SOUTH":
                    case "S":
                    case "South":
                    case "east":
                    case "E":
                    case "e":
                    case "EAST":
                    case "East":
                        chest=0;
                        movment = actingOpt;
                        actingOpt = movment;
                        switch (actingOpt)
                        {
                            case "west":
                            case "WEST":
                            case "W":
                            case "w":
                            case "West":

                                i = positionW(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                Console.WriteLine("i is: " + i);
                                break;
                            case "north":
                            case "n":
                            case "NORTH":
                            case "North":
                            case "N":
                                i = positionN(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                Console.WriteLine("i is: " + i);
                                break;
                            case "south":
                            case "s":
                            case "SOUTH":
                            case "S":
                            case "South":
                                i = positionS(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                Console.WriteLine("i is: " + i);
                                break;
                            case "east":
                            case "E":
                            case "e":
                            case "EAST":
                            case "East":
                                i = positionE(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                Console.WriteLine("i is: " + i);
                                break;
                        }
                        if (i == 1)
                        {
                            switch (movment)
                            {
                                case "west":
                                case "WEST":
                                case "W":
                                case "w":
                                case "West":
                                    chest=0;
                                    room = newpositionW(room, movment);
                                    
                                    break;
                                case "north":
                                case "n":
                                case "NORTH":
                                case "North":
                                case "N":
                                    chest=0;
                                    room = newpositionN(room, movment);
                                    break;
                                case "south":
                                case "s":
                                case "SOUTH":
                                case "S":
                                case "South":
                                    chest=0;
                                    Console.WriteLine("chest is "+chest);
                                    room = newpositionS(room, movment);
                                    if((room==32) || (room == 46) || (room == 56) || (room == 55) || (room == 18) || (room == 75))
                                    {
                                        chest=1;
                                    }
                                    Console.WriteLine("chest is " + chest);
                                    break;
                                case "east":
                                case "E":
                                case "e":
                                case "EAST":
                                case "East":
                                    chest=0;
                                    room = newpositionE(room, movment);
                                    if((room==32) || (room == 46) || (room == 56) || (room == 55) || (room == 84) || (room == 89))
                                    {
                                        chest=1;
                                    }
                                    break;
                            }

                            Console.WriteLine("You moved " + movment + " to room #" + room);
                        }
                        break;

                    //                                                                          take/grab
                    case "take":
                    case "grab":

                        i2 = 0;
                        while ((inventory1[i2]=="empty") && (i2<10))
                        {
                            i2++;
                        }
                        if (i2 >= 11)
                        {
                            Console.WriteLine("Your inventory is full");

                        }
                        else
                        {
                            if (chest == 1)
                            {
                                Random rand = new Random();
                            numberOfItems = rand.Next(4);
                            Console.WriteLine("The chest contains "+numberOfItems+" item/s");
                            for (i = 1; 1 <= numberOfItems; i++)
                            {
                                
                                while ((inventory1[i2]=="empty") && (i2!=10))
                                 {
                                    i2++;
                                 }
                                itemType = "weapon"; // itemGen();
                                switch (itemType)
                                {
                                    case "weapon":
                                        weaponType = weaponType1();
                                        weaponLvl = weaponLvl3(playerLvl);
                                        if (weaponLvl <= 1)
                                        {
                                            Console.WriteLine("You found a "+weaponType);
                                            inventory1[i2] = ""+ weaponType+"";
                                        }
                                        if (weaponLvl == 2)
                                        {
                                            iii = rand.Next(4);
                                            if (iii == 1)
                                            {
                                                prefix = prefix2();
                                                Console.WriteLine("You found a " +prefix+ " " +weaponType);
                                                inventory1[i2] = ""+prefix+ " "+weaponType+"";
                                            }
                                            if (iii == 2)
                                            {
                                                suffix = suffix2();
                                                Console.WriteLine("You found a "+ weaponType+" of " +suffix);
                                                inventory1[i2] = ""+ weaponType+" of " +suffix+"";
                                            }
                                            if (iii == 3)
                                            {
                                                weaponPlus=1;
                                                Console.WriteLine("You found a +"+ weaponPlus+" "+weaponType);
                                                inventory1[i2] = "+"+ weaponPlus+" " +weaponType+"";
                                            }
                                        }
                                        if (weaponLvl >= 3)
                                        {
                                            iii = rand.Next(5);
                                            if (iii == 1)
                                            {
                                                prefix = prefix2();
                                                suffix = suffix2();
                                                weaponPlus = weaponLvl - 2;
                                                Console.WriteLine("You found +"+ weaponPlus+" " + prefix + " " + weaponType+" of "+suffix);
                                                inventory1[i2] = "+" + weaponPlus + " " + prefix + " " + weaponType + " of " + suffix;
                                            }
                                            if (iii == 2)
                                            {
                                                suffix = suffix2();
                                                weaponPlus = weaponLvl - 1;
                                                Console.WriteLine("You found a " + weaponType + " of " + suffix);
                                                inventory1[i2] = ""+ weaponType+" of " +suffix;
                                            }
                                            if (iii == 3)
                                            {
                                                prefix = prefix2();
                                                weaponPlus = weaponLvl - 1;
                                                Console.WriteLine("You found a " + prefix + " " + weaponType);
                                                inventory1[i2] = ""+ prefix+" " +weaponType;
                                            }
                                            if (iii == 4)
                                            {
                                                weaponPlus = weaponLvl;
                                                Console.WriteLine("You found a +" + weaponPlus + " " + weaponType);
                                                inventory1[i2] = "+"+ weaponPlus+" " +weaponType;
                                            }

                                        }
                                            break;

                                    case "armor":
                                        
                                            break;
                                    case "accessory":
                                        
                                            break;
                                    case "junk":
                                        
                                            break;
                                    case "ammunition":
                                        
                                            break;
                                    case "magical":
                                        
                                            break;
                        
                                
                                }
                                 
                            }
                            }

                            inventory1[i2] = itemTaking(room, inv1, inv2, inv3, inv4, inv5, gold, silver, chopper);
                            if (inventory1[i2] == "key0")
                            {
                                key0 = 1;
                            }

                            if (inventory1[i2] == "key1")
                            {
                                key1 = 1;
                            }

                            if (inventory1[i2] == "eatingknife")
                            {
                                weaponBD = 10;
                                weaponCC = 10;
                                weaponCD = 2;
                            }
                           // i2 = 0;
                        }
                        inventory1[i2] = itemTaking(room, inv1, inv2, inv3, inv4, inv5, gold, silver, chopper);
                        break;

                    /*item = itemTaking(room, inv1, inv2, inv3, inv4, inv5, gold, silver, chopper);
                    if (inv1 == "empty")
                    {
                        inv1 = item;
                    }
                    else 
                    {
                        if (inv2 == "empty")
                        {
                           inv2 = item;
                        }
                        else 
                        {
                            if (inv3 == "empty")
                            {
                                inv3 = item;
                            }
                            else 
                            {
                              if (inv4 == "empty")
                              {
                                  inv4 = item;
                              }
                              else 
                                   {
                                        if (inv5 == "empty")
                                        {
                                            inv4 = item;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Your inventory is full.");
                                        }
                                   }
                              }
                        }
                    }
                        */
                       /* if (item == "key0")
                        {
                            key0=1;
                        }

                        if (item == "key1")
                        {
                            key1=1;
                        }

                        if (item == "eatingknife")
                        {
                            weaponBD = 10;
                            weaponCC = 10;
                            weaponCD = 2;                            
                        }*/
                        
                        
                    case "help":
                    case "Help":
                    case "HELP":
                        Console.WriteLine("Look - will alow you to look around.\nMove - will alow you to move North, East, South or West.\n");
                        break;

                    case "open":
                    case "OPEN":
                    case "Open":
                        door = opening(room, movment, key0, key1);
                        if (door == 1 && chest == 0)
                        {
                            if ((room == 72) && (movment == "south"))
                            {
                                //Console.WriteLine("The door opens.");
                                door5 = 1;
                            }
                            if ((room == 72) && (movment == "east"))
                            {
                                //   Console.WriteLine("The door opens.");
                                door1 = 1;
                            }

                            if (room == 32)
                            {
                                Console.WriteLine("The door opens.");
                                door0 = 1;
                            }
                        }
                        if (door == 0 && chest == 1)
                        {
                            Random rand = new Random();
                            numberOfItems = rand.Next(3);
                            numberOfItems++;
                            numberOfItems++;
                            Console.WriteLine("The chest contain "+numberOfItems+" items");
                            for (i = 0; i < numberOfItems; i++)
                            {
                                i2 = 0;

                                if (inventory1[i2] == "empty")
                                {
                                    inventory1[i2] = "full";
                                    i2++;
                                    i--;
                                }
                                else
                                { i2++;
                                
                                }
                                


                               /* itemType = "weapon"; //itemGen();
                                switch (itemType)
                                {
                                    case "weapon":
                                        weaponType = weaponType1();
                                        weaponLvl = weaponLvl3(playerLvl);
                                        if (weaponLvl == 1)
                                        {
                                            Console.WriteLine("You found a "+weaponType);
                                        }
                                        if (weaponLvl == 2)
                                        {
                                            iii = rand.Next(3);
                                            if (iii == 1)
                                            {
                                                prefix = prefix2();
                                                Console.WriteLine("You found a " +prefix+ " " +weaponType);
                                            }
                                            if (iii == 2)
                                            {
                                                suffix = suffix2();
                                                Console.WriteLine("You found a "+ weaponType+" of " +suffix);
                                            }
                                        }
                                        if (weaponLvl >= 3)
                                        {
                                            iii = rand.Next(4);
                                            if (iii == 1)
                                            {
                                                prefix = prefix2();
                                                suffix = suffix2();
                                                weaponPlus = weaponLvl - 2;
                                                Console.WriteLine("You found a " + prefix + " " + weaponType);
                                            }
                                            if (iii == 2)
                                            {
                                                suffix = suffix2();
                                                Console.WriteLine("You found a " + weaponType + " of " + suffix);
                                            }
                                            if (iii == 3)
                                            {
                                                suffix = suffix2();
                                                Console.WriteLine("You found a " + weaponType + " of " + suffix);
                                            }
                                        }
                                            break;

                                    case "armor":
                                        
                                            break;
                                    case "accessory":
                                        
                                            break;
                                    case "junk":
                                        
                                            break;
                                    case "ammunition":
                                        
                                            break;
                                    case "magical":
                                        
                                            break;
                        
                                
                                }*/
                            }



                        }

                        if (door == 1 && chest == 1)
                        {
                            Console.WriteLine("Do you want to open the door or the chest?");
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "door":
                                case "DOOR":
                                case "Door":
                                case "D":
                                case "d":


                                    if ((room == 72) && (movment == "south"))
                                    {
                                        //Console.WriteLine("The door opens.");
                                        door5 = 1;
                                    }
                                    if ((room == 72) && (movment == "east"))
                                    {
                                        //   Console.WriteLine("The door opens.");
                                        door1 = 1;
                                    }

                                    if (room == 32)
                                    {
                                        Console.WriteLine("The door opens.");
                                        door0 = 1;
                                    }

                                    break;

                                case "chest":
                                case "CHEST":
                                case "Chest":
                                case "C":
                                case "c":

                                    break;
                            }
                            
                        }
                        if (door == 0 && chest == 0)
                        {
                            Console.WriteLine("There is nothing to open in this room");
                        }
                        
                        break;
                        
                    case "clear":
                    case "CLEAR":
                    case "Clear":
                        Console.Clear();
                        break;

                    case "move":
                    case "Move":
                    case "MOVE":
                        Console.WriteLine("Choose a direction. (north/east/west/south)");

                      movment = Console.ReadLine();
                         switch (movment)
                            {
                                  case "west":
                                     i = positionW(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                       break;
                                  case "north":
                                     i = positionN(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                       break;
                                  case "south":
                                     i = positionS(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                       break;
                                  case "east":
                                     i = positionE(room, movment, door1, door2, door3, door4, door5, sdoor6, sdoor7, door0);
                                       break;
                            }

                        if (i == 1)
                            {
                                switch (movment)
                                  {
                                    case "west":
                                       room = newpositionW(room, movment);
                                       break;
                                    case "north":
                                       room = newpositionN(room, movment);
                                       break;
                                    case "south":
                                        room = newpositionS(room, movment);
                                       break;
                                    case "east":
                                       room = newpositionE(room, movment);
                                       break;
                                  }

                                    Console.WriteLine("You moved " + movment + " to room #" + room);
                            }
                /*else
                {
                    Console.WriteLine("This way is blocked.");
                }*/
                        break;

                    case "inventory":
                    case "Inventory":
                    case "INVENTORY":
                    case "inv":
                    case "Inv":
                    case "INV":
                        j = 1;
                        while (j<=inventory1.Length)
                        {
                            
                            for (k = 0; k < inventory1.Length; k++)
                            {
                                System.Console.Write("Slot {0}: ", j);
                                
                                System.Console.WriteLine(inventory1[k]);
                                j++;
                            }
                            
                            
                        }
                        inventory(/*inv1, inv2, inv3, inv4, inv5,*/ gold, silver, chopper);
                        
                        break;
                }
                Console.WriteLine("Please choose your next action");
            }
        }

        //                                                                  is movment possible?

        static int positionN(int room, string movment, int door1, int door2, int door3, int door4, int door5, int sdoor6, int sdoor7, int door0)
        {
            int i = 0;

            switch (room)
            {
                case 1:
                    i = 0;
                    Console.WriteLine("This way is blocked.");
                    break;
                case 2:
                    i = 0;
                    Console.WriteLine("This way is blocked.");
                    break;
                case 3:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 4:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 5:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 6:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 7:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 8:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 9:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 11:
                    i = 1;
                    break;
                case 12:
                    i = 1;
                    break;
                case 13:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 14:
                    i = 1;
                    break;
                case 15:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 16:
                    i = 1;
                    break;
                case 17:
                    i = 1;
                    break;
                case 18:
                    i = 1;
                    break;
                case 19:
                    i = 1;
                    break;
                case 21:
                    i = 1;
                    break;
                case 22:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 23:
                    i = 1;
                    break;
                case 24:
                    i = 1;
                    break;
                case 25:
                    i = 1;
                    break;
                case 26:
                    i = 1;
                    break;
                case 27:
                    i = 1;
                    break;
                case 28:
                    i = 0;Console.WriteLine("This way is blocked.");
                    break;
                case 29:
                    if (door3 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 31:
                    i = 1;
                    break;
                case 32:
                    i = 1;
                    break;
                case 33:
                    if (door2 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 34:
                    i = 1;
                    break;
                case 35:
                    i = 0;
                    break;
                case 36:
                    i = 0;
                    break;
                case 37:
                    i = 0;
                    break;
                case 38:
                    i = 0;
                    break;
                case 39:
                    i = 1;
                    break;
                case 41:
                    i = 0;
                    break;
                case 42:
                    i = 0;
                    break;
                case 43:
                    i = 1;
                    break;
                case 44:
                    i = 0;
                    break;
                case 45:
                    i = 0;
                    break;
                case 46:
                    if (door4 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 47:
                    i = 1;
                    break;
                case 48:
                    i = 1;
                    break;
                case 49:
                    i = 1;
                    break;
                case 51:
                    i = 1;
                    break;
                case 52:
                    i = 1;
                    break;
                case 53:
                    i = 0;
                    break;
                case 54:
                    i = 0;
                    break;
                case 55:
                    i = 1;
                    break;
                case 56:
                    i = 1;
                    break;
                case 57:
                    i = 1;
                    break;
                case 58:
                    i = 1;
                    break;
                case 59:
                    i = 1;
                    break;

                case 61:
                    i = 1;
                    break;
                case 62:
                    i = 0;
                    break;
                case 63:
                    i = 1;
                    break;
                case 64:
                    i = 0;
                    break;
                case 65:
                    i = 0;
                    break;
                case 66:
                    i = 0;
                    break;
                case 67:
                    i = 0;
                    break;
                case 68:
                    i = 1;
                    break;
                case 69:
                    i = 1;
                    break;
                case 71:
                    i = 0;
                    break;
                case 72:
                    i = 1;
                    break;
                case 73:
                    i = 1;
                    break;
                case 74:
                    i = 0;
                    break;
                case 75:
                    i = 1;
                    break;
                case 76:
                    i = 0;
                    break;
                case 77:
                    i = 0;
                    break;
                case 78:
                    i = 1;
                    break;
                case 79:
                    i = 1;
                    break;
                case 81:
                    i = 1;
                    break;
                case 82:
                    if (door5 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 83:
                    i = 1;
                    break;
                case 84:
                    i = 0;
                    break;
                case 85:
                    i = 0;
                    break;
                case 86:
                    i = 1;
                    break;
                case 87:
                    i = 0;
                    break;
                case 88:
                    i = 0;
                    break;
                case 89:
                    i = 0;
                    break;
            }

            return (i);
        }

        static int positionE(int room, string movment, int door1, int door2, int door3, int door4, int door5, int sdoor6, int sdoor7, int door0)
        {

            int i = 0;

            switch (room)
            {
                case 1:
                    i = 0;
                    break;
                case 2:
                    i = 1;
                    break;
                case 3:
                    i = 1;
                    break;
                case 4:
                    i = 1;
                    break;
                case 5:
                    i = 1;
                    break;
                case 6:
                    i = 1;
                    break;
                case 7:
                    i = 0;
                    break;
                case 8:
                    i = 0;
                    break;
                case 9:
                    i = 0;
                    break;
                case 11:
                    i = 1;
                    break;
                case 12:
                    i = 1;
                    break;
                case 13:
                    i = 0;
                    break;
                case 14:
                    i = 0;
                    break;
                case 15:
                    i = 0;
                    break;
                case 16:
                    i = 0;
                    break;
                case 17:
                    i = 0;
                    break;
                case 18:
                    i = 0;
                    break;
                case 19:
                    i = 0;
                    break;
                case 21:
                    i = 0;
                    break;
                case 22:
                    i = 0;
                    break;
                case 23:
                    i = 0;
                    break;
                case 24:
                    i = 0;
                    break;
                case 25:
                    i = 1;
                    break;
                case 26:
                    i = 0;
                    break;
                case 27:
                    i = 1;
                    break;
                case 28:
                    i = 1;
                    break;
                case 29:
                    i = 0;
                    break;
                case 31:
                    if (door0 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 32:
                    i = 0;
                    break;
                case 33:
                    i = 0;
                    break;
                case 34:
                    i = 1;
                    break;
                case 35:
                    i = 1;
                    break;
                case 36:
                    i = 0;
                    break;
                case 37:
                    i = 1;
                    break;
                case 38:
                    i = 0;
                    break;
                case 39:
                    i = 0;
                    break;
                case 41:
                    i = 1;
                    break;
                case 42:
                    i = 1;
                    break;
                case 43:
                    i = 1;
                    break;
                case 44:
                    i = 0;
                    break;
                case 45:
                    i = 1;
                    break;
                case 46:
                    i = 0;
                    break;
                case 47:
                    i = 0;
                    break;
                case 48:
                    i = 0;
                    break;
                case 49:
                    i = 0;
                    break;
                case 51:
                    i = 0;
                    break;
                case 52:
                    i = 0;
                    break;
                case 53:
                    i = 1;
                    break;
                case 54:
                    if (door4 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 55:
                    i = 1;
                    break;
                case 56:
                    if (door4 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 57:
                    i = 0;
                    break;
                case 58:
                    i = 1;
                    break;
                case 59:
                    i = 0;
                    break;

                case 61:
                    i = 1;
                    break;
                case 62:
                    i = 0;
                    break;
                case 63:
                    i = 0;
                    break;
                case 64:
                    i = 1;
                    break;
                case 65:
                    i = 1;
                    break;
                case 66:
                    i = 1;
                    break;
                case 67:
                    i = 1;
                    break;
                case 68:
                    i = 0;
                    break;
                case 69:
                    i = 0;
                    break;
                case 71:
                    i = 0;
                    break;
                case 72:
                    if (door1 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 73:
                    i = 1;
                    break;
                case 74:
                    i = 0;
                    break;
                case 75:
                    i = 0;
                    break;
                case 76:
                    i = 1;
                    break;
                case 77:
                    i = 1;
                    break;
                case 78:
                    i = 0;
                    break;
                case 79:
                    i = 0;
                    break;
                case 81:
                    i = 1;
                    break;
                case 82:
                    i = 0;
                    break;
                case 83:
                    if (sdoor6 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 84:
                    i = 0;
                    break;
                case 85:
                    i = 1;
                    break;
                case 86:
                    i = 1;
                    break;
                case 87:
                    if (sdoor7 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case 88:
                    i = 1;
                    break;
                case 89:
                    i = 0;
                    break;
            }

            return (i);

        }

        static int positionW(int room, string movment, int door1, int door2, int door3, int door4, int door5, int sdoor6, int sdoor7, int door0)
        {

            int i = 0;

            switch (room)
            {
                case 1:
                case 11:
                case 21:
                case 31:
                case 41:
                case 51:
                case 61:
                case 71:
                case 81:
                case 2:
                case 8:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 22:
                case 23:
                case 24:
                case 25:
                case 27:
                case 39:
                case 37:
                case 34:
                case 33:
                case 45:
                case 47:
                case 48:
                case 49:
                case 58:
                case 53:
                case 52:
                case 63:
                case 64:
                case 69:
                case 79:
                case 76:
                case 75:
                case 72:
                case 83:
                case 85:
                    
                    i = 0;
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 12:
                case 13:
                case 26:
                case 28:
                case 29:
                case 35:
                case 36:
                case 38:
                case 42:
                case 43:
                case 44:
                case 46:
                case 54:
                case 56:
                case 59:
                case 68:
                case 67:
                case 66:
                case 65:
                case 62:
                case 74:
                case 77:
                case 78:
                case 89:
                case 87:
                case 86:
                case 82:
                    i = 1;
                    break;

                case 32:
                    if (door0 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;

                case 55:
                case 57:
                    if (door4 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;

                case 73:
                    if (door1 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
            }

            return (i);
        }

        static int positionS(int room, string movment, int door1, int door2, int door3, int door4, int door5, int sdoor6, int sdoor7, int door0)
        {

            int i = 0;

            switch (room)
            {
                case 1:
                case 2:
                case 4:
                case 6:
                case 7:
                case 8:
                case 9:
                case 11:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 21:
                case 22:
                case 24:
                case 29:
                case 33:
                case 37:
                case 38:
                case 39:
                case 41:
                case 42:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 51:
                case 53:
                case 58:
                case 59:
                case 62:
                case 63:
                case 65:
                case 68:
                case 69:
                case 71:
                case 73:
                case 76:
                    i = 1;
                    break;

                case 3:
                case 5:
                case 12:
                case 18:
                case 25:
                case 26:
                case 27:
                case 28:
                case 31:
                case 32:
                case 34:
                case 35:
                case 43:
                case 44:
                case 52:
                case 54:
                case 55:
                case 56:
                case 57:
                case 61:
                case 64:
                case 66:
                case 67:
                case 74:
                case 75:
                case 77:
                case 78:
                case 79:
                case 81:
                case 82:
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                    i = 0;
                    break;

                case 23:
                    if (door2 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;

                case 36:
                    if (door4 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;

                case 72:
                    if (door5 == 0)
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
            }

            return (i);
        }


        //                                                                          new room
        static int newpositionN(int room, string movment)
        {
            room -= 10;

            return (room);
        }

        static int newpositionE(int room, string movment)
        {

            room++;

            return (room);

        }

        static int newpositionW(int room, string movment)
        {

            room--;

            return (room);
        }

        static int newpositionS(int room, string movment)
        {

            room += 10;

            return (room);
        }

        //                                                                                          Look
        static int Look(int room, string movment)
        {
            int i = 0;

            switch (room)
            {
                case 1:
                    Console.WriteLine("Room Description");
                    break;
                case 2:
                    Console.WriteLine("Room Description");
                    break;
                case 3:
                    Console.WriteLine("Room Description");
                    break;
                case 4:
                    Console.WriteLine("Room Description");
                    break;
                case 5:
                    Console.WriteLine("Room Description");
                    break;
                case 6:
                    Console.WriteLine("Room Description");
                    break;
                case 7:
                    Console.WriteLine("Room Description");
                    break;
                case 8:
                    Console.WriteLine("Room Description");
                    break;
                case 9:
                    Console.WriteLine("Room Description");
                    break;
                case 11:
                    Console.WriteLine("something something");
                    break;
                case 12:
                    Console.WriteLine("Room Description");
                    break;
                case 13:
                    Console.WriteLine("Room Description");
                    break;
                case 14:
                    Console.WriteLine("something something");
                    break;
                case 15:
                    Console.WriteLine("Room Description");
                    break;
                case 16:
                    Console.WriteLine("Room Description");
                    break;
                case 17:
                    Console.WriteLine("something something");
                    break;
                case 18:
                    Console.WriteLine("Room Description");
                    break;
                case 19:
                    Console.WriteLine("Room Description");
                    break;
                case 21:
                    Console.WriteLine("Room Description");
                    break;
                case 22:
                    Console.WriteLine("You are in a dark and cold room.\nIn the room you find a lamp which its fire is not long extinguished.\nA food plate with meat leftovers and an eating knife placed in the north of your room.\n your room extend to the south.\nYou are surounded by walls to the north, west and east.");
                    break;
                case 23:
                    Console.WriteLine("Room Description");
                    break;
                case 24:
                    Console.WriteLine("Room Description");
                    break;
                case 25:
                    Console.WriteLine("Room Description");
                    break;
                case 26:
                    Console.WriteLine("Room Description");
                    break;
                case 27:
                    Console.WriteLine("Room Description");
                    break;
                case 28:
                    Console.WriteLine("Room Description");
                    break;
                case 29:
                    Console.WriteLine("Room Description");
                    break;
                case 31:
                    Console.WriteLine("Room Description");
                    break;
                case 32:
                    Console.WriteLine("There is a locked door to your west.\nYou also spot a folded scroll to your feet.");
                    break;
                case 33:
                    Console.WriteLine("Room Description");
                    break;
                case 34:
                    Console.WriteLine("Room Description");
                    break;
                case 35:
                    Console.WriteLine("Room Description");
                    break;
                case 36:
                    Console.WriteLine("Room Description");
                    break;
                case 37:
                    Console.WriteLine("Room Description");
                    break;
                case 38:
                    Console.WriteLine("Room Description");
                    break;
                case 39:
                    Console.WriteLine("Room Description");
                    break;
                case 41:
                    Console.WriteLine("something something");
                    break;
                case 42:
                    Console.WriteLine("");
                    break;
                case 43:
                    Console.WriteLine("");
                    break;
                case 44:
                    Console.WriteLine("something something");
                    break;
                case 45:
                    Console.WriteLine("");
                    break;
                case 46:
                    Console.WriteLine("");
                    break;
                case 47:
                    Console.WriteLine("something something");
                    break;
                case 48:
                    Console.WriteLine("");
                    break;
                case 49:
                    Console.WriteLine("");
                    break;
                case 51:
                    Console.WriteLine("");
                    break;
                case 52:
                    Console.WriteLine("");
                    break;
                case 53:
                    Console.WriteLine("");
                    break;
                case 54:
                    Console.WriteLine("");
                    break;
                case 55:
                    Console.WriteLine("");
                    break;
                case 56:
                    Console.WriteLine("");
                    break;
                case 57:
                    Console.WriteLine("");
                    break;
                case 58:
                    Console.WriteLine("");
                    break;
                case 59:
                    Console.WriteLine("");
                    break;

                case 61:
                    Console.WriteLine("");
                    break;
                case 62:
                    Console.WriteLine("");
                    break;
                case 63:
                    Console.WriteLine("");
                    break;
                case 64:
                    Console.WriteLine("");
                    break;
                case 65:
                    Console.WriteLine("");
                    break;
                case 66:
                    Console.WriteLine("");
                    break;
                case 67:
                    Console.WriteLine("");
                    break;
                case 68:
                    Console.WriteLine("");
                    break;
                case 69:
                    Console.WriteLine("");
                    break;
                case 71:
                    Console.WriteLine("something something");
                    break;
                case 72:
                    Console.WriteLine("");
                    break;
                case 73:
                    Console.WriteLine("");
                    break;
                case 74:
                    Console.WriteLine("something something");
                    break;
                case 75:
                    Console.WriteLine("");
                    break;
                case 76:
                    Console.WriteLine("");
                    break;
                case 77:
                    Console.WriteLine("something something");
                    break;
                case 78:
                    Console.WriteLine("");
                    break;
                case 79:
                    Console.WriteLine("");
                    break;
                case 81:
                    Console.WriteLine("");
                    break;
                case 82:
                    Console.WriteLine("");
                    break;
                case 83:
                    Console.WriteLine("");
                    break;
                case 84:
                    Console.WriteLine("");
                    break;
                case 85:
                    Console.WriteLine("");
                    break;
                case 86:
                    Console.WriteLine("");
                    break;
                case 87:
                    Console.WriteLine("");
                    break;
                case 88:
                    Console.WriteLine("");
                    break;
                case 89:
                    Console.WriteLine("");
                    break;
            }
            return (i);

           
        }
        //                                                                          SHOW INVENTORY
        static void inventory(/*string inv1, string inv2, string inv3, string inv4, string inv5,*/ int gold, int silver, int chopper)
        {

            Console.WriteLine("Money: "+gold+" gold, "+silver+" silver, and "+chopper+" Chopper coins.");
            //Console.WriteLine("first slot: " + inv1 + "\nSecond slot: " + inv2 + "\nThird slot: " + inv3 + "\nForth slot: " + inv4 + "\nFifth slot: " + inv5);
            
        }

        //                                                                      taking

        static string itemTaking(int room, string inv1, string inv2, string inv3, string inv4, string inv5, int gold, int silver, int chopper)
        { 
            string item="empty";
            switch(room)
            {
                    
                case 32:
                    item = "key0";
                    Console.WriteLine("You took the key");
                    break;
                case 71:
                    item = "key1";
                    Console.WriteLine("You took the key");
                    break;
                case 22:
                    item = "eatingknife";
                    Console.WriteLine("You took the knife");
                    break;
                
            }

            return(item);
        }
        //chest check
        /*static int chestChecking (int room, */


        //                                                                                  open

        static int opening (int room, string movment, int key0, int key1)
        {
            int door=0;
            if  ((room == 32) && (key0==1) /*&& (movment=="west")*/)
            {
                Console.WriteLine("The door opens.");
                door = 1;
            }
            if ((room == 72) && (key1 == 1) && (movment == "east"))
            {
                Console.WriteLine("The door opens.");
                door = 1;
            }
            if ((room == 72) && (movment == "south"))
            {
                Console.WriteLine("The door opens.");
                door = 1;
            }
            return (door);
        }

        //                                                                                      item gen

        static string itemGen()
        {
            Random rand;

            int item;
            string itemType="a";
            

            
            
                rand = new Random();
                item = rand.Next(8);
                switch (item)
                {
                    case 1:
                        itemType = "weapon";
                        break;
                    case 2:
                        itemType = "armor";
                        break;
                    case 3:
                        itemType = "accessory";
                        break;
                    case 4:
                        itemType = "junk";
                        break;
                    case 5:
                        itemType = "ammunition";
                        break;
                    case 6:
                        itemType = "magical";
                        break;
                    case 7:
                        itemType = "money";
                        break;
                    case 8:
                        itemType = " ";
                        break;
                    case 9:
                        itemType = " ";
                        break;


                }
                return (itemType);
            }
        //                                                                                      Weapon Type
        static string weaponType1()
        {
            string weaponT="none";
            int rnd;
            Random rand;
            rand = new Random();
            rnd = rand.Next(11);

            switch (rnd)
            {
                case 1:
                    weaponT = "Long Sword";
                    break;
                case 2:
                    weaponT = "Great-Sword";
                    break;
                case 3:
                    weaponT = "Hand Axe";
                    break;
                case 4:
                    weaponT = "Great-Axe";
                    break;
                case 5:
                    weaponT = "Flachion";
                    break;
                case 6:
                    weaponT = "Scimitar";
                    break;
                case 7:
                    weaponT = "LongBow";
                    break;
                case 8:
                    weaponT = "ShortBow";
                    break;
                case 9:
                    weaponT = "Staff";
                    break;
                case 10:
                    weaponT = "wand";
                    break;
            }
            return(weaponT);
        }
        //                                                                          prefix
        static string prefix2()
        {   
            int i;
            string prefix1="none";
            Random Rand = new Random();
            i = Rand.Next(4);

            switch (i)
            {
                case 1:
                    prefix1 = "Flaming";
                    break;
                case 2:
                    prefix1 = "Shocking";
                    break;
                case 3:
                    prefix1 = "Icy";
                    break;
            }

            return (prefix1);
        }
        //                                                                          suffix
        static string suffix2()
        {
            int i;
            string suffix1 = "none";
            Random Rand = new Random();
            i = Rand.Next(4);

            switch (i)
            {
                case 1:
                    suffix1 = "fire burst";
                    break;
                case 2:
                    suffix1 = "lightning burst";
                    break;
                case 3:
                    suffix1 = "ice blast";
                    break;
            }

            return (suffix1);
        }
        //                                                                              Weapon Level
        static int weaponLvl3(int playerLvl)
        {
            int a, weaponLvl;
            Random Rand = new Random();

            a = Rand.Next(3);

            weaponLvl = playerLvl - 2 + a;

            return (weaponLvl);
        }
        //                                                                              Player HP
        static int playerHP(int con, int playerLvl)
        {
            int health=20;

            health = 20 + ((con - 8) / 2) * playerLvl;

            return (health);
        }

        
    
    
   }
    
        

            
        
}

    

