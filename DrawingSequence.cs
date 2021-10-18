using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class DrawingSequence
    {
        // DrawingSequence creates an matrix that is used to draw the board
        public List<List<int>> Matrix;
        public List<int> Row;


        public int RowLength;
        public int Rows;

        public DrawingSequence()
        {
            // When a object of the class DrawingSequence is created.
            // A matrix that is used as the board game design is created.
            RowLength = 9;
            Rows = 10;

            Row = new List<int>();           

         
            Matrix = new List<List<int>>();
            CreateDrawingSequence();
        }   


        public List<int> CreateRow(int rowNum)
        {
            // Creates a single row for the matrix.
            var number = 0;
            var row = new List<int>();

            for (int i = RowLength * rowNum; i < RowLength * rowNum + RowLength; i++)
            {
               
                number = (i + 1);
                row.Add(number);
            }

            if (rowNum % 2 == 0)
            {
                row.Reverse();
            }
            return row;
        }


        public void CreateDrawingSequence()
        {
            // Puts all the rows in a matrix.
            // This matrix is used to print the board game to 
            // Console.
            for (int i = 0; i < Rows ; i++)
            {
                Matrix.Add(CreateRow(i));
            }
        }
    }
}