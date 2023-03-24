using System;

namespace Robot
{
    public abstract class BareRobot
    {
        private int posX { get; set; }
        private int posY { get; set; }
        private Directions dir; // Rover direction
        private int stepLength; // Step length

        public BareRobot(int step)
        {
            posX = 1;
            posY = 1;
            dir = Directions.North;
            stepLength = step;
        }

        public abstract string Instructions(string command);

        public (int, int, string) GetPosition()
        {

            return (posX, posY, dir.ToString());
        }
        public string GetPositionToString()
        {

            return $"{posX},{posY},{dir.ToString()}";
        }

        public void TurnLeft()
        {
            dir = dir.TurnLeft();
        }

        public void TurnRight()
        {
            dir = dir.TurnRight();
        }

        public (int, int) GetMoveDirection()
        {
            return dir.Move(posX, posY, stepLength);
        }

        public void Move(int x, int y)
        {
            posX = x;
            posY = y;
        }


    }

    public class Robot : BareRobot
    {
        public Robot(int step) : base(step)
        {
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