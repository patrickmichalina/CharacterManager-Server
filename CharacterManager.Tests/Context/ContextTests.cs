using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CharacterManager.Models;

namespace CharacterManager.Tests.Context
{
    [TestClass]
    public class ContextTests
    {
        private static CharacterManager.Models.Context _systemUnderTest;

        [ClassInitialize]
        public static void BeforeEachTest(TestContext testContext)
        {
            _systemUnderTest = new CharacterManager.Models.Context();
        }

        [ClassCleanup]
        public static void AfterEachTest()
        {
            _systemUnderTest = null;
        }

        [TestMethod]
        public void PropertiesShouldSetAndGet()
        {
            throw new NotImplementedException();
        }
    }
}
