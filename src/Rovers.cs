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

        public override string Instructions(string commands)
        {
            // bool possibleMove = true;
            // for (int i = 0; i < moves.Length; i++)
            // {
            //     switch (moves[i].ToString())
            //     {

            //         case "F":
            //             possibleMove = MakeMove();
            //             break;
            //         case "L":
            //             TurnLeft();
            //             break;
            //         case "R":
            //             TurnRight();
            //             break;

            //     }

            //     if (!possibleMove)
            //     {
            //         return "Instruction no valid!";
            //     }
            // }
            // (int, int, string) position = GetPosition();
            // return position.Item1 + "," + position.Item2 + "," + position.Item3;
            foreach (var command in commands)
            {
                switch (command.ToString())
                {
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;
                    case "F":
                        (int, int) newPosition = GetMoveDirection();
                        Move(newPosition.Item1, newPosition.Item2);
                        break;
                    default:
                        throw new ArgumentException($"Invalid command: {command}");

                }
            }

            return GetPositionToString();

        }
    }
}