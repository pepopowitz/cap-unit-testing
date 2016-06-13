using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._4_Exceptions;
using NUnit.Framework;

namespace CAP.UnitTestingAndTDD.Tests._4_Exceptions
{
    [TestFixture]
    public class NUnit
    {
        [Test]
        public void GivenNullName_ThrowsArgumentNullException()
        {
            var picker = new ColorPicker();

            Assert.Throws<ArgumentNullException>(
                () =>
                    picker.PickColor(null));
        }
    }
}
