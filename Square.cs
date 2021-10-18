using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Square
    {
        public int StartPosition;
        public int CurrentPosition;  
        public int NextPosition;
        public int Dice;

        public int FromPosition;
        public int ToPosition;      
        
        public Ladder Ladder;
        public Dictionary<int, int?> Dict;
        public Dictionary<int, int> Ladders;   

        public Square()
        {
            Dict = new Dictionary<int, int?>();
        }


        public void MoveToSquare()
        {             
            if (Dict[CurrentPosition] != null)
            {
                NextPosition = (int)Dict[CurrentPosition];
            }

            else
            {
                NextPosition = CurrentPosition;
            }

            CurrentPosition = NextPosition;
        }


        //public void NextSquare()
        //{
        //    NextPosition = CurrentPosition + Dice;
        //}        
    }
}