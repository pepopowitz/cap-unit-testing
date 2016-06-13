using System;
using CAP.UnitTestingAndTDD._3_LetsUnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAP.UnitTestingAndTDD.Tests._3_LetsUnitTest
{
    [TestClass]
    public class TellFortuneTests
    {
        [TestMethod]
        public void GivenNullName_ReturnsNoFuture()
        {
            var fortuneTeller = new FortuneTeller();

            var result = fortuneTeller.TellFortune(null);

            Assert.AreEqual(result, FortuneTeller.NoFuture);
        }
    }
}
