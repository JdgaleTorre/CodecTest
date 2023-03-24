using System;
using Robot;

namespace Rovers
{
    public class RoversRobot : Robot.BareRobot
    {
        private Plateau _plateau;
        private int _distance { get; set; }

        public RoversRobot(Plateau plateau, int stepLength) : base(stepLength)
        {
            _plateau = plateau;
            _distance = 1;
        }

        public override string Instructions(string commands)
        {
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
                        if (_plateau.IsValidPosition(newPosition.Item1, newPosition.Item2))
                        {
                            Move(newPosition.Item1, newPosition.Item2);
                        }
                        else
                        {
                            return ($"Invalid move! outside of Plateau limits");
                        }

                        break;
                    default:
                        throw new ArgumentException($"Invalid command: {command}");

                }
            }

            return GetPositionToString();

        }
    }
}