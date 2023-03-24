using NUnit.Framework;
using Rovers;
using System;

namespace Rovers.Test
{
    public class RoversRobotTest
    {
        [Test]
        public void Move()
        {
            Rovers.RoversRobot newRover = new Rovers.RoversRobot(5, 5);
            Assert.AreEqual("1,4,West", newRover.Instructions("FFRFLFLF"));
        }

        [Test]
        public void ZeroMove()
        {
            Rovers.RoversRobot newRover = new Rovers.RoversRobot(5, 5);
            Assert.AreEqual("1,1,North", newRover.Instructions(""));
        }

        [Test]
        public void JustTurningLeft()
        {
            Rovers.RoversRobot newRover = new Rovers.RoversRobot(5, 5);
            Assert.AreEqual("1,1,North", newRover.Instructions("LLLL"));
        }

        [Test]
        public void InstructionNotValid()
        {
            Rovers.RoversRobot newRover = new Rovers.RoversRobot(5, 5);
            Assert.AreEqual("Instruction no valid!", newRover.Instructions("FFFFFFFF"));
        }
    }
}