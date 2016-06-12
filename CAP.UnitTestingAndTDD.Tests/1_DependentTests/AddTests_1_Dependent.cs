using System;
using CAP.UnitTestingAndTDD._1_DependentTests;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._1_DependentTests
{
    [TestFixture]
    public class AddTests_1_Dependent
    {
        Calculator _calculator = new Calculator();

        [Test]
        public void GivenAdd5_Returns5()
        {
            var result = _calculator.Add(5);

            Assert.AreEqual(5, result);
        }

        [Test]
        public void GivenAdd10_Returns10()
        {
            var result = _calculator.Add(10);

            Assert.AreEqual(10, result);
        }
    }
}
