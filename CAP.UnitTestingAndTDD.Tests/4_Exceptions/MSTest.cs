using System;
using CAP.UnitTestingAndTDD._4_Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAP.UnitTestingAndTDD.Tests._4_Exceptions
{
    [TestClass]
    public class MSTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullName_ThrowsArgumentNullException()
        {
            var picker = new ColorPicker();

            picker.PickColor(null);

            //assertion is handled by ExpectedException attribute
        }
    }
}
