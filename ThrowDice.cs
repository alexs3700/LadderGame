using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class ThrowDice
    {
        public int Dice;
        public Random Random;

        public ThrowDice()
        {
            Random = new Random();
            GenerateRandomDice();
        }

        public void GenerateRandomDice()
        {
            Dice = Random.Next(1, 6);
        }
    }
}