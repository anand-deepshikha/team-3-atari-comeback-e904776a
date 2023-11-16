using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {

        [SetUp]
        public void SetUp()
        {
            testObj = new Map();
        }

        [Test]
        public void TestMapCreatesPositionsWhenInitialized()
        {
            Assert.NotNull(testObj.positions);
            Assert.AreEqual(100, testObj.positions.Length);
            Position samplePosition = testObj.positions[4,3];
            Assert.AreEqual(4, samplePosition.x);
            Assert.AreEqual(3, samplePosition.y);
            Assert.NotNull(testObj.startingPosition);
        }

        
    }
}