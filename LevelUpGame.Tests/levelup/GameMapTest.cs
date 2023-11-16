using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        Map testObj;
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

        
    }
}