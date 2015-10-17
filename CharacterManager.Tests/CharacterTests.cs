using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterManager.Models;

namespace CharacterManager.Tests
{
    [TestClass]
    public class CharacterTests
    {
        private static Character _systemUnderTest;

        [ClassInitialize]
        public static void BeforeEachTest(TestContext testContext)
        {
            _systemUnderTest = new Character
            {
                Name = "Aleron",
                Class = new Class { },
                Faction = new Faction { },
                Race = new Race { },
                IsDeleted = false,
                Level = 50
            };
        }

        [ClassCleanup]
        public static void AfterEachTest()
        {
            _systemUnderTest = null;
        }

        [TestMethod]
        public void PropertiesShouldSetAndGet()
        {
            Assert.AreEqual("Aleron", _systemUnderTest.Name);
            Assert.AreEqual(false, _systemUnderTest.IsDeleted);
            Assert.AreEqual(50, _systemUnderTest.Level);
            ExtendedAssert.AreEqualByJson(new Faction { }, _systemUnderTest.Faction);
            ExtendedAssert.AreEqualByJson(new Class { }, _systemUnderTest.Class);
            ExtendedAssert.AreEqualByJson(new Race { }, _systemUnderTest.Race);
        }

        [TestMethod]
        public void ShouldNeverLetLevelAbove90()
        {
            _systemUnderTest.Level = 100;
            Assert.AreEqual(90, _systemUnderTest.Level);
        }

        [TestMethod]
        public void ShouldNeverLetLevelBelow1()
        {
            _systemUnderTest.Level = 0;
            Assert.AreEqual(1, _systemUnderTest.Level);

            _systemUnderTest.Level = -1;
            Assert.AreEqual(1, _systemUnderTest.Level);
        }

        [TestMethod]
        public void ModelShouldValidate()
        {
            throw new NotImplementedException();
        }        
    }
}
