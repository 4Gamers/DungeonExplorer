using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using DungeonExplorer.xml;

namespace DungeonExplorer.game
{
    [Serializable()]
    class Player
    {
        #region Private
        private string _playerName;
        private Config.Race _playerRace;
        private int _playerHealth;
        private int LocationX = 1; // 1-9
        private int LocationY = 0; // 0-8
        #endregion

        #region Public
        public string Name
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public int Location
        {
            get { return (this.LocationY * 10 + this.LocationX); }
            set { LocationY = value / 10; LocationX = value % 10; }
        }

        public string Race
        {
            get { return Enum.GetName(typeof(Config.Race), _playerRace); }
            set { _playerRace = (Config.Race)Enum.Parse(typeof(Config.Race), value); }
        }

        public int Hp
        {
            get { return _playerHealth; }
            set { _playerHealth = value; }
        }
        #endregion

        public Player()
            : this("Prisoner", "N/A")
        {
        }

        public Player(string playerName, string playerRace)
            : this(playerName, playerRace, 100)
        {
        }

        public Player(string playerName, string playerRace, int playerHealth)
        {
            this.Name = playerName;
            this.Race = playerRace;
            this.Hp = playerHealth;

            switch (this._playerRace)
            {
                case Config.Race.Elf:
                    Console.WriteLine("I AM " + this.Race);
                    break;
            }
        }

        public bool ChangeMap(int map)
        {
            if (map >= 1 && map <= 89) // Limits
                if (Maps.MapExists(map) && Maps.getMap(map).From(this.Location))
                {
                    this.Location = map;
                    return true;
                }
            return false;
        }

        public static Player CreatePlayer(Player p)
        {
            string name = ReadName();
            Console.WriteLine();
            System.Threading.Thread.Sleep(200); // Sleep

            Console.WriteLine("Hello {0}, what race were you born into?", name);
            string race = ReadRace(name);

            return new Player(name, race); // Create player
        }

        public static string ReadName()
        {
            Console.Write("\nPlease type your name: ");
            string name = Console.ReadLine();
            while (name == null)
                name = Console.ReadLine();
            return name;
        }

        public static string ReadRace(string name)
        {
            Console.WriteLine(Config.Races + "?");

            string race = Console.ReadLine();
            race = char.ToUpper(race[0]) + race.Substring(1).ToLower();

            if (!Enum.IsDefined(typeof(Config.Race), race))
                return ReadRace(name); // Not exists, ask again

            Config.Race c = (Config.Race)Enum.Parse(typeof(Config.Race), race);

            Console.WriteLine();
            switch (c)
            {
                case Config.Race.Elf:
                    Console.WriteLine("Elves are Commonly referred to as the Fair Folk, Elves are a long-lived people who have populated many places following their retreat from Xen'drix. The stereotypical (and true) physical description of an elf includes large pointed ears; slanted eyes; elegant, angled faces; somewhat short physique, and dark forest-green eyes; finally, most differences between male and female elves are marginal.");
                    Console.WriteLine(@"Racial Traits:
+2 Dexterity, -2 Constitution
Immunity to sleep spells and effects
+2 saving throw bonus against enchantment spells or effects");
                    break;
                case Config.Race.Orc:
                    Console.WriteLine("Orcs are extremely strong and have a bonus modifier to Strength. Orcs also have a penalty to Charisma and Intelligence, and generally they have less charisma and intelligence than most other races. Orcs excel in melee combat.");
                    Console.WriteLine(@"Racial Traits:
+2 Strength
-2 Intelligence
-2 Charisma");
                    break;
                case Config.Race.Dwarf:
                    Console.WriteLine("Dwarves are known for their skill in warfare, their ability to withstand physical and magical punishment and their hard work.");
                    Console.WriteLine(@"Racial Traits:
+2 Constitution, –2 Charisma.
Weapon Familiarity: Dwarves may treat dwarven axe as martial weapons, rather than exotic weapons.
+4 racial bonus on balance ability checks.
+2 racial bonus on Search checks.
+2 racial bonus on saving throws against poison.
+2 racial bonus on saving throws against spells.
+1 racial bonus on attack rolls against orcs and goblinoids.");
                    break;
                case Config.Race.Human:
                    Console.WriteLine("Humans are well rounded race that can excel at any class, with no outstanding benefits and virtually no flaws they are an excellent choice for any player new to the Dungeons & Dragons gaming system and the world of Eberron.");
                    Console.WriteLine(@"Racial Traits:
+4 skill points at character creation
+1 skill point at every level after level 1
1 bonus feat at level 1.");
                    break;
                case Config.Race.Halfling:
                    Console.WriteLine("Halflings are clever, capable and resourceful survivors. They are notoriously curious and show a daring that many larger people can’t match.");
                    Console.WriteLine(@"Racial Traits
+2 Dexterity, –2 Strength
+1 size bonus to Armor Class
+1 size bonus on attack rolls
+4 size bonus on Hide checks
+2 racial bonus on Jump, Listen, and Move Silently checks.
+1 racial bonus on all saving throws.
+2 morale bonus on saving throws against fear: This bonus stacks with the halfling’s +1 bonus on saving throws in general.
+1 racial bonus on attack rolls with thrown weapons.
Carrying capacity is three-quarters of that of a Medium character.
-4 intimidate penalty for each class size lower (-4 vs. normal, -8 vs. large).");
                    break;
            }
            Console.WriteLine();

            Console.WriteLine("Are you sure you are a {0}? (Y/N)", race);

            if (Console.ReadLine().ToUpper() != "Y")
                return ReadRace(name); // Ask again

            return race;
        }
    }
}
