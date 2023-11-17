using NUnit.Framework;
using levelup;
using System.Drawing;
using System.Diagnostics;
using System;
//using GameMap;

namespace levelup
{
    [TestFixture]
    public class GameMapTest : GameMap
    {
        GameMap testObj = new GameMap();
        [SetUp]
        public void SetUp()
        {
           testObj = new GameMap();
        }

        [Test]
        public void TestMapCreatesPositionsWhenInitialized()
        {
    
            Assert.AreEqual(100, testObj.getTotalPositions);
        }

        [Test]
        public void TestIsPositionValid()
        {
            Assert.AreEqual(true, testObj.isPositionValid(new Position(1,2)));
            Assert.AreEqual(false, testObj.isPositionValid(new Position(-1,2)));
            Assert.AreEqual(false, testObj.isPositionValid(new Position(1,-2)));
            Assert.AreEqual(true, testObj.isPositionValid(new Position(5,7)));
            Assert.AreEqual(true, testObj.isPositionValid(new Position(0,0)));
            Assert.AreEqual(true, testObj.isPositionValid(new Position(9,9)));
        }

        [Test]
        public void TestMove() {
            Position startPosition = new Position(1,1);
            calculatePosition(startPosition, GameController.DIRECTION.NORTH);
            Position result = GetNewPosition();
            Console.WriteLine("X = " + result.X);
            Console.WriteLine("Y = " + result.Y);
            Assert.IsNotNull(result);
           //Assert.AreEqual(1, result.X);
            //Assert.AreEqual(2, result.Y);
        }
    
    }
}