using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class Game
    { 
        // Constants
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;

        // Variables
        public int playerOnePosition = 0;
        public int playerTwoPosition = 0;
        public int dieCountPOne = 0;
        public int dieCountPTwo = 0;
        public int winPosition = 100;

        /// <summary>
        /// Method to get die number for both players
        /// </summary>
        /// <returns></returns>
        public int DieRoller()
        {
            Random random = new Random();
            int dieRoller = random.Next(1, 7);
            return dieRoller;
        }

        /// <summary>
        /// Method to get snake or ladder for both players
        /// </summary>
        /// <returns></returns>
        public int CheckOption()
        {
            Random random = new Random();
            int snakeOrLadder = random.Next(0, 3);
            return snakeOrLadder;
        }

        /// <summary>
        /// Method for actual game
        /// </summary>
        public void LiveGame()
        {            
            while (playerOnePosition != 100 && playerTwoPosition != 100)
            {
                int playerOneDieNumber = DieRoller();                
                int snakeOrLadderPOne = CheckOption();
                int playerTwoDieNumber = DieRoller();
                int snakeOrLadderPTwo = CheckOption();
                dieCountPOne++;
                dieCountPTwo++;

                Console.WriteLine("Player one rolls the die and gets : " + playerOneDieNumber);
                Console.WriteLine("Player two rolls the die and gets : " + playerTwoDieNumber);

                switch (snakeOrLadderPOne)
                {
                    case IS_LADDER:
                        Console.WriteLine("Player one gets ladder...");
                        if (playerOnePosition + playerOneDieNumber <= 100)
                            playerOnePosition += playerOneDieNumber;
                        else
                            playerOnePosition += 0;

                        // Extra chance after getting ladder
                        int extraChance = DieRoller();
                        Console.WriteLine("Player one plays again and gets : " + extraChance);
                        if (playerOnePosition + playerOneDieNumber <= 100)
                            playerOnePosition += playerOneDieNumber;
                        else
                            playerOnePosition += 0;                        
                        break;

                    case IS_SNAKE:
                        Console.WriteLine("Player one gets snake...");
                        playerOnePosition -= playerOneDieNumber;
                        if (playerOnePosition < 0)
                            playerOnePosition = 0;                        
                        break;

                    default:
                        Console.WriteLine("No play for player one...");
                        break;
                }
                Console.WriteLine("Current position of player one : " + playerOnePosition);

                switch (snakeOrLadderPTwo)
                {
                    case IS_LADDER:
                        Console.WriteLine("Player two gets ladder...");
                        if (playerTwoPosition + playerTwoDieNumber <= 100)
                            playerTwoPosition += playerTwoDieNumber;
                        else
                            playerTwoPosition += 0;

                        // Extra chance after getting ladder
                        int extraChance = DieRoller();
                        Console.WriteLine("Player two plays again and gets : " + extraChance);
                        if (playerTwoPosition + playerTwoDieNumber <= 100)
                            playerTwoPosition += playerTwoDieNumber;
                        else
                            playerTwoPosition += 0;
                        break;

                    case IS_SNAKE:
                        Console.WriteLine("Player two gets snake...");
                        playerTwoPosition -= playerTwoDieNumber;
                        if (playerTwoPosition < 0)
                            playerTwoPosition = 0;
                        break;

                    default:
                        Console.WriteLine("No play for player two...");
                        break;
                }
                Console.WriteLine("Current position of player two : " + playerTwoPosition);
            }
            if (playerOnePosition == winPosition)
                Console.WriteLine("Player One Won...");
            else if (playerTwoPosition == winPosition)
                Console.WriteLine("Player Two won...");
        }
    }
}
