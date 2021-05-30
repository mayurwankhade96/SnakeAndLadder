using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Game
    {
        public int startPosition = 0;
        const int IS_LADDER = 1;
        const int IS_SNAKE = 2;
        public void SnakeLadder()
        {
            Random die = new Random();
            int dieRoller = die.Next(1, 7);
            int SnakeOrLadder = die.Next(0, 3);

            switch (SnakeOrLadder)
            {
                case IS_LADDER:
                    startPosition += dieRoller;
                    break;

                case IS_SNAKE:
                    startPosition -= dieRoller;
                    break;

                default:                    
                    break;
            }            
        }
    }
}
