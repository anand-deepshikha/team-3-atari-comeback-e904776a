using NUnit.Framework;
using levelup;
using System.Drawing;
//using Map;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        Map testObj = new Map();
        [SetUp]
        public void SetUp()
        {
           testObj = new Map();
        }

        [Test]
        public void TestMapCreatesPositionsWhenInitialized()
        {
            Assert.NotNull(testObj.positions);
            Assert.AreEqual(100, testObj.positions);
        }

        [Test]
        public void TestIsPositionValid()
        {
            Assert.AreEqual(true, testObj.isPositionValid(new Point(1,2)));
            Assert.AreEqual(false, testObj.isPositionValid(new Point(-1,2)));
            Assert.AreEqual(false, testObj.isPositionValid(new Point(1,-2)));
        }
    
    }
}