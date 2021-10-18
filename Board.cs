using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LadderGame
{
    public class Board
    {
        public List<List<int>> Matrix;
        public Colors Colors;

        public int CurrentPosition;
        public int StartPosition;
        public int EndPosition;


        public Board()
        {
            Matrix = new List<List<int>>();
            Colors = new Colors();
        }


        public void ShowBoard()
        {
            Console.WriteLine($"Start: {StartPosition}");
            Console.WriteLine($"End: {EndPosition}");
            Console.WriteLine("---------------------------\n");

            for (int i = Matrix.Count - 1; i > -1; i--)
            {
                for (int j = Matrix[i].Count - 1; j > -1; j--)
                {
                    if (CurrentPosition < 90)
                    {
                        if (Matrix[i][j] < 10)
                        {
                            if (CurrentPosition == Matrix[i][j])
                            {
                                Colors.SetPlayerColor();
                                Console.Write(Matrix[i][j].ToString().PadLeft(2, '0') + " ");
                                Colors.ResetColors();
                            }

                            else
                            {
                                Console.Write(Matrix[i][j].ToString().PadLeft(2, '0') + " ");
                            }
                        }

                        else
                        {
                            if (CurrentPosition == Matrix[i][j])
                            {
                                Colors.SetPlayerColor();
                                Console.Write(Matrix[i][j] + " ");
                                Colors.ResetColors();
                            }

                            else
                            {
                                Console.Write(Matrix[i][j] + " ");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("You have finished the ladder game");
                        string str = "";
                        char c = '.';
                        int sleepTime = 1000;

                        Console.WriteLine("Console closes in 3 seconds.");
                        for (int k = 0; k < 3; k++)
                        { 
                            var temp = ".";                            
                            Console.Write(temp);                            
                            Thread.Sleep(sleepTime);
                        }
                        Environment.Exit(0);
                    }
                }
                    Console.WriteLine();
                }
            }
        }
    }