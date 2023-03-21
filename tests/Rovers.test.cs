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
            Rovers.RoversRobot newRover = new Rovers.RoversRobot(5,5);
            Assert.AreEqual("1,4,W", newRover.Instruction("FFRFLFLF"));
        }
    }
}