using System;

namespace Robot
{
    public abstract class BareRobot
    {
        private int posX { get; set; }
        private int posY { get; set; }
        private string dir; // Rover direction

        public bool nextMoveX { get; set; }
        public bool nextMoveSum { get; set; }

        public static class Directions
        {
            public const string North = "North";
            public const string East = "East";
            public const string South = "South";
            public const string West = "West";

        }

        public enum DirectionMove
        {
            SumX,
            SumY,
            RestX,
            RestY
        }

        public BareRobot()
        {
            posX = 1;
            posY = 1;
            dir = Directions.North;
            nextMoveX = false;
            nextMoveSum = true;
        }

        public abstract bool MakeMove();

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

        public void MoveTo(DirectionMove option, int distance)
        {
            switch (option)
            {
                case DirectionMove.SumX:
                    posX += distance;
                    break;
                case DirectionMove.SumY:
                    posY += distance;
                    break;
                case DirectionMove.RestX:
                    posX -= distance;
                    break;
                case DirectionMove.RestY:
                    posY -= distance;
                    break;
            }
        }

        public (int, int, string) GetPosition()
        {

            return (posX, posY, dir);
        }


    }

    public class Robot : BareRobot
    {
        public override bool MakeMove()
        {

            (int, int, string) position = GetPosition();
            if (nextMoveX)
            {

                if (nextMoveSum)
                {
                    MoveTo(DirectionMove.SumX, 1);
                }
                else
                {
                    MoveTo(DirectionMove.RestX, 1);
                }

            }
            else
            {

                if (nextMoveSum)
                {
                    MoveTo(DirectionMove.SumY, 1);
                }
                else
                {
                    MoveTo(DirectionMove.RestY, 1);
                }

            }
            return true;
        }
    }
}