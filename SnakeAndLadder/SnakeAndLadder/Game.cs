using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Game
    {
        public int startPosition = 0;
        public void SnakeLadder()
        {
            Random die = new Random();
            int dieRoller = die.Next(1, 7);

            Console.WriteLine("Player rolls the die and get : " + dieRoller);
        }
    }
}
