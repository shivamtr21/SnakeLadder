using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadderUC5
    {
        public const int NoPlay = 0;
        public const int LadderPlay = 1;
        public const int SnakeBite = 2;
        public const int MaxPosition = 100;

        public static void MaxPositionSnakeLadder()
        {
            Console.WriteLine("Start the Snake and Ladder Game");

            Console.WriteLine("Single Player at start Position 0");

            Console.WriteLine(" ");

            int position = 0;

            while (position != MaxPosition)
            {
                Random random = new Random();

                int Dice = random.Next(1, 6);

                Console.WriteLine("Player 1 rolls the die and get : " + Dice);

                Random random1 = new Random();
                int Time = random1.Next(3);


                switch (Time)
                {
                    case NoPlay:
                        Console.WriteLine("Option NO PLAY selected " + position);
                        Console.WriteLine("Player stay in the same position");
                        break;

                    case LadderPlay:
                        Console.WriteLine("Option LADDER selected " + (Dice + position));
                        Console.WriteLine("Player move ahead " + Dice);
                        position = Dice + position;
                        break;

                    case SnakeBite:

                        Console.WriteLine("Option SNAKE selected " + (Dice + position));
                        Console.WriteLine("Player move behind by : " + Dice);
                        position = position - Dice;
                        break;
                }

                if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("Player 1 have to restart the game from position: " + position);
                }

                if (position > 100)
                {
                    position = position - Dice;

                    Console.WriteLine("Your chance is skip stay on same position  :" + position);

                }
                Console.WriteLine("Current position of the player is :" + position);
                Console.WriteLine(" ");


            }
            Console.WriteLine("..............Player 1 reach the winning position...........");
        }


    }

}
                