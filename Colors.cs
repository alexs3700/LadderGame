using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadderGame
{
    public class Colors
    {
        // Default color
        public ConsoleColor DefaultFgColor;
        public ConsoleColor DefaultBgColor;

        // Player color
        public ConsoleColor Blue;     

        public Colors()
        {
            DefaultFgColor = ConsoleColor.White;
            DefaultBgColor = ConsoleColor.Black;

            Blue = ConsoleColor.Blue;                  
        }

        // Player for player position
        public void SetPlayerColor()
        {
            Console.ForegroundColor = Blue;          
        }     

        // Reseting to default console color values.
        public void ResetColors()
        {
            Console.ForegroundColor = DefaultFgColor;
            Console.BackgroundColor = DefaultBgColor;
        }
    }
}