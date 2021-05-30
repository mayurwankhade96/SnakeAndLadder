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

            while (startPosition != 100)
            {
                int dieRoller = die.Next(1, 7);
                Console.WriteLine("Player rolls the die and gets : " + dieRoller);

                int SnakeOrLadder = die.Next(0, 3);
                switch (SnakeOrLadder)
                {
                    case IS_LADDER:
                        Console.WriteLine("Player gets ladder");
                        startPosition += dieRoller;
                        break;

                    case IS_SNAKE:
                        Console.WriteLine("Player gets snake");
                        startPosition -= dieRoller;
                        if (startPosition < 0)
                            startPosition = 0;
                        break;

                    default:
                        Console.WriteLine("No play.");
                        break;
                }
                Console.WriteLine("Current position : " + startPosition);
            }
            Console.WriteLine("Winning position : " + startPosition);
        }
    }
}
