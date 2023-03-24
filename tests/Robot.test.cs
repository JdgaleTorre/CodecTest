using NUnit.Framework;
using Robot;
using System;

namespace Robot.Test
{
    public class RobotTest
    {
        [Test]
        public void BasicMoves()
        {
            Robot newRobot = new Robot();
            newRobot.MakeMove();
            newRobot.MakeMove();

            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(3, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }

        [Test]
        public void ZeroMove()
        {
            Robot newRobot = new Robot();
            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(1, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }

        [Test]
        public void JustTurningLeft()
        {
            Robot newRobot = new Robot();
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
            Robot newRobot = new Robot();
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
            Robot newRobot = new Robot();
            for (int i = 0; i < 10; i++)
            {
                newRobot.MakeMove();
            }

            (int, int, string) position = newRobot.GetPosition();
            Assert.AreEqual(1, position.Item1);
            Assert.AreEqual(11, position.Item2);
            Assert.AreEqual("North", position.Item3);
        }
    }
}