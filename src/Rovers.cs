using System;

namespace Rovers
{
    public class RoversRobot
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public string dir; // Rover direction

        public bool nextMoveX { get; set; }
        public bool nextMoveSum { get; set; }
        public int maxX { get; set; }
        public int maxY { get; set; }
        static class Directions
        {
            public const string North = "North";
            public const string East = "East";
            public const string South = "South";
            public const string West = "West";

        }


        public RoversRobot(int _maxX, int _maxY)
        {
            posX = 1;
            posY = 1;
            dir = Directions.North;
            nextMoveX = false;
            nextMoveSum = true;
            maxX = _maxX;
            maxY = _maxY;
        }


        public string Instruction(string moves)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i].ToString())
                {

                    case "F":
                        MakeMove();
                        break;
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;

                }
            }

            return posX + "," + posY + "," + dir;
        }

        public void MakeMove()
        {
            if (nextMoveX)
            {
                int possibleX = nextMoveSum ? posX + 1 : posX - 1;
                if (possibleX >= 1 && possibleX <= maxX)
                {
                    posX = possibleX;
                }
            }
            else
            {
                int possibleY = nextMoveSum ? posY + 1 : posY - 1;
                if (possibleY >= 1 && possibleY <= maxY)
                {
                    posY = possibleY;
                }
            }
        }

        public void TurnLeft()
        {
            switch (dir.ToString())
            {
                case Directions.North:
                    dir = Directions.West;
                    nextMoveX = true;
                    nextMoveSum = false;
                    break;
                case Directions.West:
                    dir = Directions.South;
                    nextMoveX = true;
                    nextMoveSum = false;
                    break;
                case Directions.South:
                    dir = Directions.East;
                    nextMoveSum = true;
                    nextMoveX = true;
                    break;
                case Directions.East:
                    dir = Directions.North;
                    nextMoveSum = true;
                    nextMoveX = false;
                    break;

            }
        }
        public void TurnRight()
        {
            switch (dir.ToString())
            {
                case Directions.North:
                    dir = Directions.East;
                    nextMoveX = true;
                    nextMoveSum = true;
                    break;
                case Directions.West:
                    dir = Directions.North;
                    nextMoveX = false;
                    nextMoveSum = true;
                    break;
                case Directions.South:
                    dir = Directions.West;
                    nextMoveSum = false;
                    nextMoveX = true;
                    break;
                case Directions.East:
                    dir = Directions.South;
                    nextMoveSum = false;
                    nextMoveX = false;
                    break;

            }
        }
    }
}