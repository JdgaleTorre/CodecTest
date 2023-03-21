using System;

namespace Rovers
{
    public class RoversRobot
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public string dir; // Rover direction
        string[] str_dir = { "N", "E", "S", "W" };
        public bool nextMoveX { get; set; }
        public bool nextMoveSum { get; set; }
        public int maxX { get; set; }
        public int maxY { get; set; }

        public RoversRobot(int _maxX, int _maxY)
        {
            posX = 1;
            posY = 1;
            dir = str_dir[0];
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
                case "N":
                    dir = "W";
                    nextMoveX = true;
                    nextMoveSum = false;
                    break;
                case "W":
                    dir = "S";
                    nextMoveX = true;
                    nextMoveSum = false;
                    break;
                case "S":
                    dir = "E";
                    nextMoveSum = true;
                    nextMoveX = true;
                    break;
                case "E":
                    dir = "N";
                    nextMoveSum = true;
                    nextMoveX = false;
                    break;

            }
        }
        public void TurnRight()
        {
            switch (dir.ToString())
            {
                case "N":
                    dir = "E";
                    nextMoveX = true;
                    nextMoveSum = true;
                    break;
                case "W":
                    dir = "N";
                    nextMoveX = false;
                    nextMoveSum = true;
                    break;
                case "S":
                    dir = "W";
                    nextMoveSum = false;
                    nextMoveX = true;
                    break;
                case "E":
                    dir = "S";
                    nextMoveSum = false;
                    nextMoveX = false;
                    break;

            }
        }
    }
}