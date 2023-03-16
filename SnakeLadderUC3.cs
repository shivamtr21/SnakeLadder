using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadderUC3
    {
        public const int NoPlay = 0;
        public const int PlayLadder = 1;
        public const int SnakeBite = 2;
        public static void CheckDiceChangePosition()
        {
            

            Console.WriteLine("Single player at start position 0");

            Random random = new Random();
            int Dice = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die and get : " + Dice);

            Random random1 = new Random();
            int option = random1.Next(3);

            int position = 0;

            switch (option)
            {
                case NoPlay:
                    Console.WriteLine("NO PLAY  " + position);
                    Console.WriteLine("Player stay in same position");
                    break;

                case PlayLadder:
                    Console.WriteLine("LADDER " + (Dice + position));
                    Console.WriteLine("Player move ahead : " + Dice);
                    break;

                case SnakeBite:
                    Console.WriteLine("SNAKE " + (Dice + position));
                    Console.WriteLine("Player moves behind by: " + Dice);
                    break;
            }

        }
    }
}
