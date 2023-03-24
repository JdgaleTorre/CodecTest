using NUnit.Framework;
using Robot;
using System;

namespace Robot.Test
{
    public class RobotTest
    {
        static Robot newRobot = new Robot(1);
        [SetUp]
        public static void InitializeTests()
        {
            // Creating Robot and Plateau
            newRobot = new Robot(1);
        }
        [Test]
        public void BasicMoves()
        {
            (int, int) newPosition;
            for (int i = 0; i < 2; i++)
            {
                newPosition = newRobot.GetMoveDirection();
                newRobot.Move(newPosition.Item1, newPosition.Item2);
            }


            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(3, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }

        [Test]
        public void ZeroMove()
        {
            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(1, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }

        [Test]
        public void JustTurningLeft()
        {
            newRobot.TurnLeft();
            newRobot.TurnLeft();
            newRobot.TurnLeft();
            newRobot.TurnLeft();

            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(1, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }
        [Test]
        public void JustTurningRight()
        {
            newRobot.TurnRight();
            newRobot.TurnRight();
            newRobot.TurnRight();
            newRobot.TurnRight();

            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(1, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }

        [Test]
        public void MakingTenMoves()
        {
            (int, int) newPosition;
            for (int i = 0; i < 10; i++)
            {
                newPosition = newRobot.GetMoveDirection();
                newRobot.Move(newPosition.Item1, newPosition.Item2);
            }

            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(11, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }
    }
}