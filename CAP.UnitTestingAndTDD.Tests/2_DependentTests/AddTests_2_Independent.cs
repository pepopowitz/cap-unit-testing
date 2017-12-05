using System;
using CAP.UnitTestingAndTDD._2_DependentTests;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._2_DependentTests
{
    [TestFixture]
    public class AddTests_2_Independent
    {

        [Test]
        public void GivenAdd5_Returns5()
        {
            var _calculator = new Calculator();

            var result = _calculator.Add(5);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void GivenAdd10_Returns10()
        {
            var _calculator = new Calculator();

            var result = _calculator.Add(10);

            Assert.AreEqual(10, result);
        }
    }
}
