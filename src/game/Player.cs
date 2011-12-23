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
                    Console.WriteLine("I AM "+this.Race);
                    break;
            }
        }

        public static void CreatePlayer(Player p)
        {
            string name = ReadName();
            Console.WriteLine();
            System.Threading.Thread.Sleep(200); // Sleep

            Console.WriteLine("Hello {0}, what race were you born into?", name);
            string race = ReadRace(name);

            p = new Player(name, race); // Create player
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
            Console.WriteLine(Config.Classes+"?");

            string race = Console.ReadLine();
            race = char.ToUpper(race[0]) + race.Substring(1).ToLower();

            if (!Enum.IsDefined(typeof(Class), race))
                return ReadRace(name); // Not exists

            Class c = (Class)Enum.Parse(typeof(Class), race);

            switch (c)
            {
                case Class.Elf:
                    Console.WriteLine("Elves are strong");
                    break;
            }

            Console.WriteLine("Are you sure you are a {0}? (Y/N)", race);

            if (Console.ReadLine().ToUpper() != "Y")
                return ReadRace(name);

            return race;
        }
    }
}
