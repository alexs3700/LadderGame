using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LadderGame
{
    public class UpdateView
    {
        // This class updates the model class
            
        public int? CurrentPosition;

        public int Dice;

        public UpdateView(Model model)
        {
            // Binds the Model object created in the main class, Program
           
                                 
            // When CurrentPosition is changed, the updated view
            // will give an updated board also.

          
            int[] currentPositions = {1, 2, 33, 90};
            // The array currentPositions creates an array of 4 different positions.
            // Position 1, has an upladder and will be 40.
            // Position 2, has no ladder, and will be 2.
            // Position 33, has a downLadder, and will be 3.
            // Position 90 is reached when you have finished the game
            // When position 90 is reached, the console will exit.


            foreach (var pos in currentPositions)
            {
                // This foreach loops through the different positions
                // of the int array currentPositions.
                // The CurrentPosition of the model is changed to one of
                // of the positions at a time.
                // A new board is created for each new positions.
                // When CurrentPositions equals 90, the console will quit after 
                // about 3 seconds.
                Console.Clear();
                CurrentPosition = pos;
                model.CurrentPosition = (int)CurrentPosition;
                model.CreateModel();
                Thread.Sleep(2500);                
            }
           
            Console.ReadLine();
        } 
    }
}