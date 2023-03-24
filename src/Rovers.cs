using System;
using Robot;

namespace Rovers
{
    public class RoversRobot : Robot.BareRobot
    {
        private int _maxX { get; set; }
        private int _maxY { get; set; }
        private int _distance { get; set; }

        public RoversRobot(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
            _distance = 1;
        }

        public string Instruction(string moves)
        {
            bool possibleMove = true;
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i].ToString())
                {

                    case "F":
                        possibleMove = MakeMove();
                        break;
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;

                }

                if (!possibleMove)
                {
                    return "Instruction no valid!";
                }
            }
            (int, int, string) position = GetPosition();
            return position.Item1 + "," + position.Item2 + "," + position.Item3;
        }

        public override bool MakeMove()
        {
            (int, int, string) position = GetPosition();
            if (nextMoveX)
            {
                int possibleX = nextMoveSum ? position.Item1 + 1 : position.Item1 - 1;
                if (possibleX >= 1 && possibleX <= _maxX)
                {
                    if (nextMoveSum)
                    {
                        MoveTo(DirectionMove.SumX, _distance);
                    }
                    else
                    {
                        MoveTo(DirectionMove.RestX, _distance);
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int possibleY = nextMoveSum ? position.Item2 + 1 : position.Item2 - 1;
                if (possibleY >= 1 && possibleY <= _maxY)
                {
                    if (nextMoveSum)
                    {
                        MoveTo(DirectionMove.SumY, _distance);
                    }
                    else
                    {
                        MoveTo(DirectionMove.RestY, _distance);
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

    }
}