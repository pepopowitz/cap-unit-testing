using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP.UnitTestingAndTDD._4_Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CAP.UnitTestingAndTDD.Tests._4_Exceptions
{
    [TestClass]
    public class FrameworkIndependent
    {
        [TestMethod]
        public void GivenNullName_ThrowsArgumentNullException()
        {
            var picker = new ColorPicker();

            try
            {
                picker.PickColor(null);
            }
            catch (ArgumentNullException)
            {
                //We caught an argument null exception so this test passes!
                return;
            }

            Assert.Fail("Should have thrown null argument exception but did not.");
        }
    }
}
