using NUnit.Framework;
using System;

namespace Plateau.Test
{
    public class PlateauTest
    {
        static Plateau newPlateau = new Plateau(5, 5);
        [SetUp]
        public static void InitializeTests()
        {
            // Creating Robot and Plateau
            newPlateau = new Plateau(5, 5);
        }
        [Test]
        public void PlateauCreated()
        {
            Assert.AreEqual(true, newPlateau.IsValidPosition(1, 1));
        }
        [Test]
        public void PlateauValidPosition()
        {
            Assert.AreEqual(true, newPlateau.IsValidPosition(5, 5));
        }
        [Test]
        public void PlateauInvalidPosition()
        {
            Assert.AreEqual(false, newPlateau.IsValidPosition(1, 6));
        }


    }
}