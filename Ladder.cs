using System;
using System.Collections.Generic;


namespace LadderGame
{
	public class Ladder
	{
        public bool? IsUp;
        public bool HasLadder;

        public Dictionary<int, int?> Dict;
        public Dictionary<int, bool?> Dict2;
        public Dictionary<int, bool> Dict3;


        public Dictionary<int, int> Ladders;
        public Dictionary<int, int> UpLadders;
        public Dictionary<int, int> DownLadders;

        public int CurrentPosition;
        public int StartPosition;
        public int EndPosition;
      

        public Ladder()
        {
            Dict = new Dictionary<int, int?>();
            Dict2 = new Dictionary<int, bool?>();
            Dict3 = new Dictionary<int, bool>();

            InitializeLadders();
            SetLadderPositions();
            CurrentPosition = 1;
            HasALadder(CurrentPosition);
            CheckIfLadderIsUp(CurrentPosition);

            var str2 = "";

            if ((bool)IsUp)
            {
                str2 = "has an upladder";
            }

            else if ((bool)!IsUp)
            {
                str2 = "has a downLadder";
            }

            else {
                str2 = "";
            }
            string str3 = "";

           
                   



            var str = HasLadder ? "Position has a ladder" : "Position has not a ladder";

            var str1 = $"Position: {CurrentPosition} \n" +
                      $"HasLadder: {HasLadder}\n" +
                      $"IsUp: {IsUp}\n" +
                      $"Start: {StartPosition}\n" +
                      $"End: {EndPosition}\n";
                



            Console.WriteLine(str1);
           
        }


        public void InitializeLadders()
        {
            for (var i = 0; i < 90; i++)
            {
                Dict.Add((i + 1), null);
            }
        }

        public void HasALadder(int position)
        {
            HasLadder =  Dict[position] != null;
            StartPosition = position;
            EndPosition = (int)Dict[position];
         }

       

        public void CheckIfLadderIsUp(int position)
        {
            if (HasLadder)
            {
                IsUp =  Dict[position] > position;
             }

            else
            {
                IsUp = null;
            }           
        }

        public void SetLadderPositions()
        {
            // Declaring the Up ladders positions.
            Dict[1] = 40;
            Dict[8] = 10;
            Dict[36] = 52;
            Dict[43] = 62;
            Dict[49] = 79;
            Dict[65] = 82;
            Dict[68] = 85;

            // Declaring the down ladders positions.
            Dict[24] = 5;
            Dict[33] = 3;
            Dict[42] = 30;
            Dict[56] = 37;
            Dict[64] = 27;
            Dict[74] = 12;
            Dict[87] = 70;
        }

     
       
        }
    }
	