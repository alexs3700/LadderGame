using System;

namespace LadderGame
{
    class Program
    {
        // This class start the console application.
        public static Model Model;
        public static Ladder Ladder;

        public static UpdateView UpdateView;

        static void Main(string[] args)
        {
            //Model = new Model();            
            //UpdateView = new UpdateView(Model);
            Model = new Model();
            UpdateView = new UpdateView(Model);
            Console.ReadLine();
        }
        }
    }