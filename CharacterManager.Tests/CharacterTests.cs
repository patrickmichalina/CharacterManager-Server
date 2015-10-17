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
                IsDeleted = false
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
            ExtendedAssert.AreEqualByJson(new Faction { }, _systemUnderTest.Faction);
            ExtendedAssert.AreEqualByJson(new Class { }, _systemUnderTest.Class);
        }

        
    }
}
