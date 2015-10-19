using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterManager.Tests.Context
{
    [TestClass]
    public class ContextTests
    {
        private static CharacterManager.Models.ApplicationContext _systemUnderTest;

        [ClassInitialize]
        public static void BeforeEachTest(TestContext testContext)
        {
            _systemUnderTest = new CharacterManager.Models.ApplicationContext();
        }

        [ClassCleanup]
        public static void AfterEachTest()
        {
            _systemUnderTest = null;
        }

        [TestMethod]
        public void PropertiesShouldExists()
        {
            var test = typeof(CharacterManager.Models.ApplicationContext).GetProperty("Characters");
        }

        [TestMethod]
        public void PropertiesShouldSetAndGet()
        {
            throw new NotImplementedException();
        }
    }
}
