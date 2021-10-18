using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LadderGame
{
    public class Model
    {
        // Creates objects of Board, Square and Ladder class.
        public Board Board;
        public Square Square;
        public Ladder Ladder;

        public List<List<int>> Matrix;
       
        public Dictionary<int, int?> Dict;
        public Dictionary<int, int> Ladders;
        public DrawingSequence DrawingSequence;
        public ThrowDice ThrowDice;

        // Define positions
        public int StartPosition;
        public int EndPosition;
        public int CurrentPosition;
        public int Dice;
        public int NextPosition;


        public Model()
        {
            // When a model object is constructed.
            // This constructor is called.
            // This constructor initialize the Model before
            // use.
            InitModel();
            CreateModel();
        }

        public void InitModel()
        {
            // Initiates the needed objects of the Model.
           
            Ladder = new Ladder();
            ThrowDice = new ThrowDice();

            Dice = ThrowDice.Dice;
            Dict = new Dictionary<int, int?>();
            DrawingSequence = new DrawingSequence();
            Matrix = new List<List<int>>();

            CurrentPosition = 1;

            // Creates the drawing sequence
            Matrix = DrawingSequence.Matrix;         
           
        }

        public void CreateModel()
        {
            // Creates the a new Square and Board object.
            NewSquare();
            NewBoard();
            Board.ShowBoard();
        }

        public void NewSquare()
        {
            // Creates a new square each time NewSquare() is called.
            Square = new Square() { };

            // Bind Square to Model
            Square.CurrentPosition = CurrentPosition;
            StartPosition = CurrentPosition;

            Square.Ladder = Ladder;
            Square.Dict = Ladder.Dict;
            Square.Dice = Dice;
            Square.MoveToSquare();
            CurrentPosition = Square.CurrentPosition;
            EndPosition = CurrentPosition;
        }

        public void NewBoard()
        {
            // Create a new Board object each time NewBoard() is called.
            // Binds Board to Model
            Board = new Board();
            Board.Matrix = Matrix;
            Board.CurrentPosition = CurrentPosition;
            Board.StartPosition = StartPosition;
            Board.EndPosition = EndPosition;
        }
    }
}