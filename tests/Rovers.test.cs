using NUnit.Framework;
using Rovers;
using System;

namespace Rovers.Test
{
    public class RoversRobotTest
    {
        static Rovers.RoversRobot newRover = new Rovers.RoversRobot(new Plateau.Plateau(5, 5), 1);
        [SetUp]
        public static void InitializeTests()
        {
            // Creating Robot and Plateau
            Plateau.Plateau newPlateau = new Plateau.Plateau(5, 5);
            newRover = new Rovers.RoversRobot(newPlateau, 1);
        }
        [Test]
        public void Move()
        {

            Assert.AreEqual("1,4,West", newRover.Instructions("FFRFLFLF"));
        }

        [Test]
        public void ZeroMove()
        {
            Assert.AreEqual("1,1,North", newRover.Instructions(""));
        }

        [Test]
        public void JustTurningLeft()
        {
            Assert.AreEqual("1,1,North", newRover.Instructions("LLLL"));
        }

        [Test]
        public void InstructionNotValid()
        {
            Assert.AreEqual("Invalid move! outside of Plateau limits", newRover.Instructions("FFFFFFFF"));
        }
    }
}