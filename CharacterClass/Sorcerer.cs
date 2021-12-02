using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterClass
{
    public class Sorcerer
    {
        public Sorcerer() { }

        public Sorcerer(int health, PrimaryStat pStat, Save saveOne, Save saveTwo)
        {
            Health = health;
            PrimaryStat = pStat;
            SaveOne = saveOne;
            SaveTwo = saveTwo;
        }

        private int _health { get; set; }
        public int Health
        {
            get { return _health; }
            set
            {
                if (value == 6)
                    Console.WriteLine("You have full health: 6hp.");
                else if (value <= 0)
                    Console.WriteLine("LOL U DED.");
                else
                    _health = value;
            }
        }
        public PrimaryStat PrimaryStat { get; set; }
        public Save SaveOne { get; set; }
        public Save SaveTwo { get; set; }

    }
}
