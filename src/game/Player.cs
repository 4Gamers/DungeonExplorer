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
        private string _playerRace;
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
            get { return _playerRace; }
            set { _playerRace = value; }
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
            this._playerName = playerName;
            this._playerRace = playerRace;
            this._playerHealth = playerHealth;
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

            while (!Enum.IsDefined(typeof(Config.Classes), race))
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
