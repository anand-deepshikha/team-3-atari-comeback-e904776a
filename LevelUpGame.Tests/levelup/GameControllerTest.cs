using NUnit.Framework;
using levelup;
using System.Drawing.Printing;



namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
         GameController testObj = new GameController();
            string character = "ATARI";
            enum direction{
                NORTH
            };

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
            Assert.IsNotNull(testObj.GetStatus());
        }
      /*

        [Test]
        public void whenTheCharacterSetsTheirNameTest()
        {
            string nameSet = testObj.CreateCharacter("characterName");
           Assert.AreNotSame(character,nameSet);
        } */
        
        [Test]
        public void GetStatusTest()
        {
            object status = testObj.GetStatus();
            Assert.IsNotEmpty(status.ToString());
        }
        
    }
}