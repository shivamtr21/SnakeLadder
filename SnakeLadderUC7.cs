
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class SnakeLadderUC7
    {
        public const int CaseOfNoPlay = 0;
        public const int CaseOfLadder = 1;
        public const int CaseOfSnake = 2;
        public const int MaxPosition = 100;
        public static void call()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Players at Start Position 0");
            Console.WriteLine(" ");
            int positionOfPlayer1 = 0;
            int positionOfPlayer2 = 0;
            int step1 = 0;
            int step2 = 0;
            bool currentTurn = true;


            while (positionOfPlayer1 != MaxPosition && positionOfPlayer2 != MaxPosition)
            {
                if (currentTurn == true)
                {
                    Random random = new Random();
                    int RollDice = random.Next(1, 6);
                    Console.WriteLine("Player 1 rolls the die and get: " + RollDice);
                    Random random1 = new Random();
                    int option = random1.Next(3);



                    switch (option)
                    {
                        case CaseOfNoPlay:

                            {
                                Console.WriteLine("option NO PLAY selected " + positionOfPlayer1);
                                Console.WriteLine("player1 stay in same position");
                                currentTurn = false;

                                break;
                            }

                        case CaseOfLadder:
                            {
                                Console.WriteLine("option LADDER selected " + (RollDice + positionOfPlayer1));
                                Console.WriteLine("player1 move ahead : " + RollDice);
                                positionOfPlayer1 = RollDice + positionOfPlayer1;
                                break;
                            }

                        case CaseOfSnake:
                            {
                                Console.WriteLine("option SNAKE selected " + (RollDice + positionOfPlayer1));
                                Console.WriteLine("Player1 moves behind by : " + RollDice);
                                positionOfPlayer1 = positionOfPlayer1 - RollDice;
                                currentTurn = false;
                                break;
                            }
                    }

                    if (positionOfPlayer1 < 0)
                    {
                        positionOfPlayer1 = 0;
                        Console.WriteLine("plyer1 have to restart the game from position:" + positionOfPlayer1);
                    }
                    if (positionOfPlayer1 > 100)
                    {
                        positionOfPlayer1 = positionOfPlayer1 - RollDice;
                        Console.WriteLine("Your chance is skip stay on same position:" + positionOfPlayer1);
                    }

                    step1++;
                    Console.WriteLine("Player1 roll the dice till now " + step1);
                    Console.WriteLine("current position of the player is:" + positionOfPlayer1);
                    Console.WriteLine(" ");
                }
                else
                {
                    Random random = new Random();
                    int RollDice = random.Next(1, 6);
                    Console.WriteLine("Player 2 rolls the die and get: " + RollDice);
                    Random random1 = new Random();
                    int option = random1.Next(3);



                    switch (option)
                    {
                        case CaseOfNoPlay:

                            {
                                Console.WriteLine("option NO PLAY selected " + positionOfPlayer2);
                                Console.WriteLine("player2 stay in same position");
                                currentTurn = true; ;

                                break;
                            }

                        case CaseOfLadder:
                            {
                                Console.WriteLine("option LADDER selected " + (RollDice + positionOfPlayer2));
                                Console.WriteLine("player2 move ahead : " + RollDice);
                                positionOfPlayer2 = RollDice + positionOfPlayer2;
                                break;
                            }

                        case CaseOfSnake:
                            {
                                Console.WriteLine("option SNAKE selected " + (RollDice + positionOfPlayer2));
                                Console.WriteLine("Player2 moves behind by : " + RollDice);
                                positionOfPlayer2 = positionOfPlayer2 - RollDice;
                                currentTurn = true;
                                break;
                            }
                    }

                    if (positionOfPlayer2 < 0)
                    {
                        positionOfPlayer2 = 0;
                        Console.WriteLine("plyer2 have to restart the game from position:" + positionOfPlayer2);

                    }
                    if (positionOfPlayer2 > 100)
                    {
                        positionOfPlayer2 = positionOfPlayer2 - RollDice;
                        Console.WriteLine("Your chance is skip stay on same position:" + positionOfPlayer2);
                    }

                    step2++;
                    Console.WriteLine("Player2 roll the dice till now " + step2);
                    Console.WriteLine("current position of the player is:" + positionOfPlayer2);
                    Console.WriteLine(" ");
                }

            }
            if (positionOfPlayer1 == 100)
            {
                Console.WriteLine("Total number of time player1 roll the dice is :" + step1);
                Console.WriteLine("!!!!*****!!!!!Player1 Reach The Winning Position!!!!*****!!!!!");
            }
            else
            {
                Console.WriteLine("Total number of time player2 roll the dice is :" + step2);
                Console.WriteLine("!!!!*****!!!!!Player2 Reach The Winning Position!!!!*****!!!!!");
            }



        }
    }
}