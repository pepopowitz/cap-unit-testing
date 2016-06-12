using System;
using CAP.UnitTestingAndTDD._1_DependentTests;
using CAP.UnitTestingAndTDD._2_RepeatableTests;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._2_RepeatableTests
{
    [TestFixture]
    public class DayTests_1_Unrepeatable
    {
        private Calendar _calendar = new Calendar();

        [Test]
        public void GivenDate_ReturnsDay()
        {
            var dateTime = DateTime.Today;

            var result = _calendar.Day(dateTime);

            Assert.AreEqual(4, result);
        }
    }
}
