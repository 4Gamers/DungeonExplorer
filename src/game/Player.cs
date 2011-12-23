using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonExplorer2008.game
{
    class Player
    {
        #region Private
        private string _playerName;
        private Class _playerRace;
        private int _playerHealth;
        #endregion

        #region Public
        public string Name
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public string Race
        {
            get { return Enum.GetName(typeof(Class), _playerRace); }
            set { _playerRace = (Class)Enum.Parse(typeof(Class), value); }
        }

        public int Hp {
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
                case Class.Elf:
                    Console.WriteLine("I AM ELF");
                    break;
            }
        }

        public static void CreatePlayer(Player p)
        {
            Console.WriteLine();
            string name = ReadName();

            System.Threading.Thread.Sleep(1000); // Sleep

            string race = ReadRace();

            p = new Player(name, race); // Create player
        }

        public static string ReadName()
        {
            Console.WriteLine("Welcome to *Game Name*");
            Console.Write("\nPlease Type your name: ");
            string name = Console.ReadLine();
            while (name == null)
                name = Console.ReadLine();
            return name;
        }

        public static string ReadRace()
        {
            Console.WriteLine("What race were you born into?");
            Console.WriteLine("Dwarf, Elf, Human, Orc or Halfling");

            string race = Console.ReadLine();
            race = char.ToUpper(race[0]) + race.Substring(1).ToLower();

            while (!Enum.IsDefined(typeof(Class), race))
            {
                Console.WriteLine("\tPlease try again");
                Console.WriteLine("Dwarf, Elf, Human, Orc or Halfling");
                race = Console.ReadLine();
                race = char.ToUpper(race[0]) + race.Substring(1).ToLower();
            }

            return race;
        }
    }
}
