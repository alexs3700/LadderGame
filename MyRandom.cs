using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class MyRandom
    {
        public Random Random;
        public int? Dice;

        public MyRandom()
        {
            Random = new Random();
            ThrowDice();
        }

        public int ThrowDice() {
            Dice = Random.Next(1, 6);
            return Dice;
        }

        
    }
}
