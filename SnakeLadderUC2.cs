using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeLadderUC2
    {
        public static void DiceCall()
        {
            Console.WriteLine("Start the Snake and Ladder Game");
            Console.WriteLine("Single player at start position 0");

            Random random = new Random();
            int Dice = random.Next(1, 6);
            Console.WriteLine("Player 1 rolls the die and get : " + Dice);
        }
    }
}
